using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ROVGyroCal_Rev02
{
    public partial class ROVGyrocalForm : Form
    {
        public ROVGyrocalForm()
        {
            InitializeComponent();
        }

        //global string for the selected CSV file
        public string fullFilePath = string.Empty;

        #region ChooseCSVButtonClick
        /// <summary>
        /// checks that the open file dialog compelted succesfully. if it did thenthe first 5 lines are populated into the preview window.
        /// if not show a messagebox to the user showing that no file was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseCSVButton_Click(object sender, EventArgs e)
        {
            string CSVFile = string.Empty;
            //checks to see if the open file dialogue was successful
            if (openCSVFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //local variable for storing the filepath and name
                CSVFile = openCSVFileDialog.FileName;
                //instantiates a stream reader to preview the file contents
                System.IO.StreamReader sr = new System.IO.StreamReader(openCSVFileDialog.FileName);
                FilePreviewTextBox.Clear();

                FilePreviewTextBox.Text += "               ";
                for (int i = 0; i < sr.ReadLine().Split(',').Length; i++)
                {
                    FilePreviewTextBox.Text += "Col" + (i+1);
                    FilePreviewTextBox.Text += "          ";
                }
                FilePreviewTextBox.AppendText(Environment.NewLine);                
                sr.BaseStream.Position = 0;
                //populates the sample data window with the first 4 lines from the file
                for (int i = 0; i < 4; i++)
                {

                    var line = sr.ReadLine();
                    var values = line.Split(',');
                    int columnCount = line.Split(',').Length;

                    FilePreviewTextBox.Text += "Row  ";
                    FilePreviewTextBox.Text += i;
                    FilePreviewTextBox.Text += " | ";
                    //internal for loop that loops through each line adding a tab for each column in the file
                    for (int k = 0; k < columnCount; k++)
                    {
                        FilePreviewTextBox.Text += values[k];
                        FilePreviewTextBox.Text += "    ";
                    }
                    
                    
                    FilePreviewTextBox.AppendText(Environment.NewLine);
                }

                //closes the streamreader
                sr.Close();
                fullFilePath = openCSVFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("No file selected!");

            }

            fullFilePath = CSVFile;
        }
        #endregion ChooseCSVButtonClick


        #region ValidateData
        /// <summary>
        /// method that attempts to parse the ROV measurements to doubles. any that do not parse will be added to a list and shown in a messagebox
        /// </summary>
        /// <returns>A bool that represents if the data is valid</returns>
        public bool ValidateData()
        {
            //a bool value that represents if the data is valid
            bool validData = true;
            //creates a string builder that is used to create the list of sections with invalid data
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The following sections contain invalid data :");


            //if statements that check each of the ROV measurements and file configuartion columns settings
            //If any contain invalid data sets validData to false and adds the section to the list of invalid sections
            if (!double.TryParse(ROVFwdMeasurementTextBox.Text, out double ROVFwd))
            {
                validData = false;
                sb.AppendLine("ROV Fwd Measurement");
            }
            else if (Convert.ToDouble(ROVFwdMeasurementTextBox.Text) < 0)
            {
                validData = false;
                sb.AppendLine("ROV Fwd Measurement must be a positive value");
            }
            if (!double.TryParse(ROVAftMeasurementTextBox.Text, out double ROVAft))
            {
                validData = false;
                sb.AppendLine("ROV Aft Measurement");
            }
            else if (Convert.ToDouble(ROVAftMeasurementTextBox.Text) < 0)
            {
                validData = false;
                sb.AppendLine("ROV Aft Measurement must be a positive value");
            }
            if (!double.TryParse(BaselineMeasurementTextBox.Text, out double Baseline))
            {
                validData = false;
                sb.AppendLine("Baseline Measurement");
            }
            else if (Convert.ToDouble(BaselineMeasurementTextBox.Text) < 0)
            {
                validData = false;
                sb.AppendLine("Baseline Measurement must be a positive value");
            }
            if (!int.TryParse(rowsToSkipTextBox.Text, out int RowsToSkip))
            {
                validData = false;
                sb.AppendLine("Rows to Skip");
            }
            if (RowsToSkip < 0)
            {
                validData = false;
                sb.AppendLine("Rows to Skip must be a positive whole number");
            }
            if (!int.TryParse(ROVHDGColumnTextBox.Text, out int ROVHDG))
            {
                validData = false;
                sb.AppendLine("ROV HDG Column");               
            }
            if (ROVHDG < 0)
            {
                validData = false;
                sb.AppendLine("ROV Heading Column must be a positive whole number");
            }
            if (!int.TryParse(vesselHDGColumnTextBox.Text, out int VesselHDG))
            {
                validData = false;
                sb.AppendLine("Vessel HDG");
            }
            if (VesselHDG < 0)
            {
                validData = false;
                sb.AppendLine("Vessel HDG Column");
            }

            //Checks that a CSV file has been selected
            if (fullFilePath == string.Empty)
            {
                validData = false;
                sb.AppendLine("You must load a .CSV File");
            }
            else
            {

            }


            //checks to see if there were any sections that had invalid data and if so lists them in a messagebox for the user
            if (validData == false)
            {
                MessageBox.Show(sb.ToString());
            }

            return validData;
        }
        #endregion ValidateData

        #region ComputeValues
        /// <summary>
        /// computes all the values needed for each observation and then adds them to a list.
        /// populates the information from eachobservation into th preview textbox
        /// validate data MUST be run prior to this as this does not check for valid data
        /// once averages are computed they are populated to the results textboxes
        /// </summary>
        public void ComputeValues()
        {
            //creates the lists for the various items for each observation and the counter to display how many observations were used
            List<string> timeStamp = new List<string>();
            List<double> observedVesselHDG = new List<double>();
            List<double> observedROVHDG = new List<double>();
            List<double> computedROVHDG = new List<double>();
            List<double> cMinusO = new List<double>();
            int ROVHDGColumn = Convert.ToInt32(ROVHDGColumnTextBox.Text);
            int VesselHDGColumn = Convert.ToInt32(vesselHDGColumnTextBox.Text);
            int observationCounter = 0;
            int errorCounter = 0;
            int rowsToSkip = 0;

            //creates a double that will hold the average C-O value
            double averageCMinusO;
            //creates a double that will hold the average vessel heading
            double averageObservedVesselHDG = 0;
            //creates a doubld that will hold the average observed ROV HDG
            double averageObservedROVHDG = 0;
            //creates a double that will hold the average computed ROV HDG
            double averageComputedROVHDG = 0;
            //creates a double and sets its value to the ROV Fwd measurement textbox
            double ROVFwdMeasurement = Convert.ToDouble(ROVFwdMeasurementTextBox.Text);
            //creates a double and sets its value to the ROV aft measurement textbox
            double ROVAftMeasurement = Convert.ToDouble(ROVAftMeasurementTextBox.Text);
            //creates a double and sets its value to the ROV aft measurement textbox
            double BaselineMeasurement = Convert.ToDouble(BaselineMeasurementTextBox.Text);
            //a double that represents the side opposite the c-o angle
            double oppositeSide;
            //a double that represents the relative c-o between the reference and the ROV
            double ROVToReference;
            //a souble that represents the c-o between the ROV and the vessel heading
            double ROVToVessel;
            //double that represents the tangent value
            double tangent;
            //creates two enums whose value will be set by if statements later
            ROVDirection rOVDirection;
            ReferenceToROV referenceToROV;

            //empties the preview textbox in preparation for outputing the observations to it in the while loop
            FilePreviewTextBox.Clear();

            //if statements that set the ROV direction value based on the radio button selected
            if (ROVFwdRadioButton.Checked)
            {
                rOVDirection = ROVDirection.Fwd;
                ROVToVessel = 0;
            }
            else if (ROVStbdRadioButton.Checked)
            {
                rOVDirection = ROVDirection.Stbd;
                ROVToVessel = 90;
            }
            else if (ROVAftRadioButton.Checked)
            {
                rOVDirection = ROVDirection.Aft;
                ROVToVessel = 180;
            }
            else
            {
                rOVDirection = ROVDirection.Port;
                ROVToVessel = 270;
            }

            //if statement that sets the refernce line relative to the ROV based on the radio button selection
            if (ReferenceToROVPortRadioButton.Checked)
            {
                referenceToROV = ReferenceToROV.Port;
            }
            else
            {
                referenceToROV = ReferenceToROV.Starboard;
            }

            //works out opposite side by taking the forward measurement from the aft
            oppositeSide = ROVFwdMeasurement - ROVAftMeasurement;
            //works out the tangent using the opposite side and baseline (adjacent)
            tangent = oppositeSide / BaselineMeasurement;
            //calculates the C-O between ROV and reference using the tangent of the angle
            ROVToReference = Math.Atan(tangent) * 180 / Math.PI;

            //if statment that applies the C-O the correct way round based on the if the reference is port or stbd of the ROV
            if (referenceToROV == ReferenceToROV.Port)
            {
                ROVToVessel = ROVToVessel + ROVToReference;
            }
            else
            {
                ROVToVessel = ROVToVessel - ROVToReference;
            }

            //if statement to make sure no values are above 360 or below 0
            if (ROVToVessel < 0)
            {
                ROVToVessel = 360 + ROVToVessel;
            }
            else if (ROVToVessel > 360)
            {
                ROVToVessel = ROVToVessel - 360;
            }            

            StreamReader fileReader = new StreamReader(fullFilePath);

            //sets the rowsToSkip int to be used for looping the streamreader to skip the desired number of rows inthe file
            rowsToSkip = Convert.ToInt32(rowsToSkipTextBox.Text);

            for (int i = 0; i < rowsToSkip; i++)
            {
                fileReader.ReadLine();
            }


            //while loop that reads to the end of the file
            while (!fileReader.EndOfStream)
            {

                //sets up some variable to use as temporary stores for each line and the separated values
                var line = fileReader.ReadLine();
                var values = line.Split(',');



                //adds the current timestamp to the list of 
                timeStamp.Add(values[0]);

                //all attempts to parse the observation are wrapped in this try. any failed attempt will put a messagebox up showing the observation # 
                //that cant be parsed
                try
                {
                    //adds the current observed ROV heading to the observedROVHDG array
                    observedROVHDG.Add(Convert.ToDouble(values[ROVHDGColumn-1]));
                    //adds the observed vessel heading to the observed vessel hdg array
                    observedVesselHDG.Add(Convert.ToDouble(values[VesselHDGColumn-1]));
                    //checks to see if the computed ROV HDG is less than zero or above 360. if soo applies an offset of 360 (+/-) to compensate
                    if (Convert.ToDouble(values[2]) + ROVToVessel > 360)
                    {
                        computedROVHDG.Add(Convert.ToDouble(values[2]) + ROVToVessel - 360);
                    }
                    else if (Convert.ToDouble(values[2]) + ROVToVessel < 0)
                    {
                        computedROVHDG.Add(Convert.ToDouble(values[2]) + ROVToVessel + 360);
                    }
                    else
                    {
                        computedROVHDG.Add(Convert.ToDouble(values[2]) + ROVToVessel);
                    }

                    //caluclates the C-O using the computed and observed ROV heading from the current observation)
                    cMinusO.Add(computedROVHDG[observationCounter] - observedROVHDG[observationCounter]);
                    //increments the observation counter on each pass

                    //adds the current observations info to the preview textbox then stars a new line
                    FilePreviewTextBox.Text += observationCounter + 1;
                    FilePreviewTextBox.AppendText(", ");
                    FilePreviewTextBox.Text += "Time, ";
                    FilePreviewTextBox.Text += timeStamp[observationCounter];
                    FilePreviewTextBox.AppendText(", ");
                    FilePreviewTextBox.Text += "Vessel (Obs), ";
                    FilePreviewTextBox.Text += observedVesselHDG[observationCounter].ToString(format: "N3");
                    FilePreviewTextBox.AppendText(", ");
                    FilePreviewTextBox.Text += "ROV (Obs), ";
                    FilePreviewTextBox.Text += observedROVHDG[observationCounter].ToString(format: "N3");
                    FilePreviewTextBox.AppendText(", ");
                    FilePreviewTextBox.Text += "ROV (Comp), ";
                    FilePreviewTextBox.Text += computedROVHDG[observationCounter].ToString(format: "N3");
                    FilePreviewTextBox.AppendText(", ");
                    FilePreviewTextBox.Text += "C-O, ";
                    FilePreviewTextBox.Text += cMinusO[observationCounter].ToString(format: "N3");                    
                    FilePreviewTextBox.AppendText(Environment.NewLine);

                    //increments the observation counter
                    observationCounter++;
                }
                catch
                {
                    MessageBox.Show("Data for observation " + (observationCounter +1) + " could not be parsed!!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    errorCounter++;
                    if (errorCounter > 5)
                    {
                        break;
                    }
                }



            }

            if (errorCounter > 5)
            {
                MessageBox.Show("More than 5 errors have been encountered, Exiting",
                "Warning!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            //releases all resources from the streamreder
            fileReader.Dispose();
            //checks to see if the observed vessel list is empty. if it is it shows an error messagebox and does nothing
            //if there is data it calculates the averages and publishes the results to the textboxes on the form
            if (observedVesselHDG.Any())
            {
                //calculates all the average values
                averageCMinusO = cMinusO.Average();
                averageObservedVesselHDG = observedVesselHDG.Average();
                averageObservedROVHDG = observedROVHDG.Average();
                averageComputedROVHDG = computedROVHDG.Average();

                //populates all the results text boxes 
                ObservationsTextBox.Text = Convert.ToString(observationCounter);
                ROVToBaselineResultsTextBox.Text = ROVToReference.ToString(format: "N3");
                AverageVesselHDGTextBox.Text = averageObservedVesselHDG.ToString(format: "N3");
                AverageComputedROVHDGTextBox.Text = averageComputedROVHDG.ToString(format: "N3");
                AverageCMinusOTextBox.Text = averageCMinusO.ToString(format: "N3");
                AverageComputedROVHDGTextBox.Text = averageObservedROVHDG.ToString(format: "N3");
                AverageROVHDGTextBox.Text = averageObservedROVHDG.ToString(format: "N3");
            }
            else
            {
                MessageBox.Show("Warning there are no observations",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }


        }

        #endregion ComputeValues

        #region ComputeButtonClick
        /// <summary>
        /// if the compute button is clicked this checks that all form data is valid and there is a CSV file loaded
        /// if all data is valid then it will compute all the values and populate the preview textbox with the results of each
        /// observation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComputeButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                ComputeValues();
            }
        }
        #endregion ComputeButtonClick

        #region CopyOutputButtonClick

        /// <summary>
        /// if the copy to clipboard button is clicked this will select all the text in the filePreviewTextBox and copy it to the clipboard
        /// if there is no data in the window it will show a messagebox to the user letting them know there is nothing to copy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyOutputButton_Click(object sender, EventArgs e)
        {
            if (FilePreviewTextBox.Text == "")
            {
                MessageBox.Show("No data to copy!");
            }
            else
            {
                Clipboard.SetText(FilePreviewTextBox.Text);
            }
        }

        #endregion CopyOutputButtonClick

        #region Text Highlight methods

        private void ROVFwdMeasurementTextBox_Enter(object sender, EventArgs e)
        {
            ROVFwdMeasurementTextBox.SelectAll();
        }

        private void ROVAftMeasurementTextBox_Enter(object sender, EventArgs e)
        {
            ROVAftMeasurementTextBox.SelectAll();
        }

        private void BaselineMeasurementTextBox_Enter(object sender, EventArgs e)
        {
            BaselineMeasurementTextBox.SelectAll();
        }

        private void rowsToSkipTextBox_Enter(object sender, EventArgs e)
        {
            rowsToSkipTextBox.SelectAll();
        }

        private void ROVHDGColumnTextBox_Enter(object sender, EventArgs e)
        {
            ROVHDGColumnTextBox.SelectAll();
        }

        private void vesselHDGColumnTextBox_Enter(object sender, EventArgs e)
        {
            vesselHDGColumnTextBox.SelectAll();
        }

        #endregion Text Highlight methods

        #region UseDefaultsButtonClick

        /// <summary>
        /// when the use defaults button is clicked sets the text values in the rows to skip, ROV hdg Column and vessel HDG column text boxes to the default values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useDefaultsButton_Click(object sender, EventArgs e)
        {
            rowsToSkipTextBox.Text = "1";
            ROVHDGColumnTextBox.Text = "2";
            vesselHDGColumnTextBox.Text = "3";
        }
        #endregion UseDefaultsButtonClick

        #region TextboxIllegalCharParsing
        //events that stop illegal characters being typed into the file configuration textboxes
        //only allows numbers and backspace
        private void rowsToSkipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsNumber(e.KeyChar);
        }        

        private void ROVHDGColumnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsNumber(e.KeyChar);
        }

        private void vesselHDGColumnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsNumber(e.KeyChar);
        }




        #endregion TextboxIllegalCharParsing

        #region ToolTips

        private void ROVFwdMeasurementTextBox_MouseEnter(object sender, EventArgs e)
        {
            ROVFWDToolTip.SetToolTip(ROVFwdMeasurementTextBox, "Measurement from the reference bulkhead to the ROV Fwd corner.");
        }

        private void ROVAftMeasurementTextBox_MouseEnter(object sender, EventArgs e)
        {
            ROVAftToolTip.SetToolTip(ROVAftMeasurementTextBox, "Measurement from the reference bulkhead to the ROV Aft corner.");
        }

        private void BaselineMeasurementTextBox_MouseEnter(object sender, EventArgs e)
        {
            BaselineToolTip.SetToolTip(BaselineMeasurementTextBox, "Measurement from the Fwd to Aft Points on the reference Bulkhead.");
        }

        private void ChooseCSVButton_MouseEnter(object sender, EventArgs e)
        {
            LoadCSVToolTip.SetToolTip(ChooseCSVButton, "Picks the CSV file containing the logged data required for the calibration.");
        }

        private void rowsToSkipTextBox_MouseEnter(object sender, EventArgs e)
        {
            RowsToSkipToolTip.SetToolTip(rowsToSkipTextBox, "The number of rows to skip at the start of the file.");
        }

        private void ROVHDGColumnTextBox_MouseEnter(object sender, EventArgs e)
        {
            ROVHDGColumnToolTip.SetToolTip(ROVHDGColumnTextBox, "The column in the file that contains the ROV's observed heading.");
        }

        private void vesselHDGColumnTextBox_MouseEnter(object sender, EventArgs e)
        {
            VesselHDGColumnToolTip.SetToolTip(vesselHDGColumnTextBox, "The column in the file that contains the vessels observed heading.");
        }

        private void useDefaultsButton_MouseEnter(object sender, EventArgs e)
        {
            UseDefaultsToolTip.SetToolTip(useDefaultsButton, "Uses the default values for number of rows to skip and clumns for the ROV and vessel headings.");
        }

        private void ComputeButton_MouseEnter(object sender, EventArgs e)
        {
            ComputeButtonToolTip.SetToolTip(ComputeButton, "Attempts to compute the observation values using the provided settings.");
        }

        private void CopyOutputButton_MouseEnter(object sender, EventArgs e)
        {
            CopyToClipboardButtonToolTip.SetToolTip(CopyOutputButton, "Copies the output from the preview window to the clipboard.");
        }

        private void ROVDirectionGroupBox_MouseHover(object sender, EventArgs e)
        {
            ROVDirectionToolTip.SetToolTip(ROVDirectionGroupBox, "Sets the ROV's direction relative to the vessels heading.");
        }

        private void ReferenceToROVGroupBox_MouseHover(object sender, EventArgs e)
        {
            RefLineToROVToolTip.SetToolTip(ReferenceToROVGroupBox, "Sets which side of the ROV the reference bulkhead will be measured from.");
        }

        #endregion ToolTips


    }
}
