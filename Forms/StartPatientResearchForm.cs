using Models;
using Models.Sensor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZedGraph;

namespace View
{
    public partial class StartPatientResearchForm : Form
    {

        private ControlService _service;
        private Research _research;
        private List<ISensor> sensors = new List<ISensor>();


        public StartPatientResearchForm()
        {
            InitializeComponent();
        }

        public StartPatientResearchForm(ControlService service, Research research)
        {
            InitializeComponent();
            _service = service;
            _research = research;

            label6.Text = _service.GetResearchInfo(research);
        }

        private void StartPatientResearchForm_Load(object sender, System.EventArgs e)
        {
            InitializeSensors();
            DrawingGraphs();
        }

        private void InitializeSensors()
        {
            if (_research.ElectrCondInd)
                sensors.Add(new ElectrCondSensor());
            if (_research.ArterialPressInd)
                sensors.Add(new ArterialPressSensor());
            if (_research.PulseInd)
                sensors.Add(new PulseSensor());
            if (_research.SkinMoisureInd)
                sensors.Add(new SkinMoisureSensor());
            if (_research.SkinTempInd)
                sensors.Add(new SkinTempSensor());
        }

        private void DrawingGraphs()
        {
            int y = 7;
            int x = 10;
            int i = 0;
            foreach (ISensor sensor in sensors)
            {
                PointPairList ppList = new PointPairList();
                ZedGraphControl graphControl = new ZedGraphControl();
                GraphPane pane = graphControl.GraphPane;

                sensor._pane = pane;     
                sensor._ppList = ppList;       
                sensor._graphControl = graphControl;
                graphControl.Location = new System.Drawing.Point(x, y);
                graphControl.Name = sensor.NameOfSensor;
                graphControl.Size = new System.Drawing.Size(350, 200);
                panel1.Controls.Add(graphControl);

                pane.Title.Text = sensor.NameOfSensor;
                pane.XAxis.Scale.Min = 0;
                pane.XAxis.Scale.Max = _research.duration + 1;
                pane.XAxis.Scale.MajorStep = 1;
                pane.YAxis.Scale.Max = sensor.MaxValue;
                pane.YAxis.Scale.MajorStep = 5;
                graphControl.AxisChange();
                graphControl.Invalidate();
              
                if (i%2 == 0)
                {
                    x += 355;
                } else
                {
                    y += 205;
                    x -= 355;
                }
                i++;
            }
        }
    }
}
