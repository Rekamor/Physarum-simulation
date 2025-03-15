using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Physarum_simulation
{
    public class Diapazone
    {
        public Diapazone(double center, double range)
        {
            minvalue = center - range;
            minvalue = center + range;
        }
        public double maxvalue { get; set; }
        public double minvalue { get; set; }
    }
    
    public partial class Physarum : Form
    {
        SimulationSettings Settings = new SimulationSettings();
        public Physarum()
        {
            InitializeComponent();
        }
        
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            
        }
        
        private class Agent
        {
            public double XPosition { get; set; }
            public double YPosition { get; set; }
            public float Direction { get; set; }
            public float Speed { get; set; }
            public float TurnAngle { get; set; }
            public float SensorLength { get; set; }
            public float SensorsAngle{ get; set; }
            public int CrazyThreshold {  get; set; }
            public int CrazyTime { get; set; }
            int CrazyTimer { get; set; }
        }

        private float NormiceMod(float value, float divider)
        {
            if (value >= 0) return value % divider;
            else return value % divider + divider;
        }
        
        private float Limit(float value, float min, float max)
        {
            return Math.Min(Math.Max(value, min), max);
        }
        
        private void SetWobbling_Click(object sender, EventArgs e)
        { 
            float wobbling;
            if (float.TryParse(WobblingBox.Text, out wobbling)) 
                Settings.Step.Wobbling = NormiceMod(wobbling, 360) - 180;
            WobblingBox.Text = Settings.Step.Wobbling.ToString();
        }

        private void SetNecessaryTurn_Click(object sender, EventArgs e)
        {
            float necessaryTurn;
            if (float.TryParse(NecessaryTurnBox.Text, out necessaryTurn)) 
                Settings.Step.NecessaryTurn = NormiceMod(necessaryTurn, 360) - 180;
            NecessaryTurnBox.Text = Settings.Step.NecessaryTurn.ToString();
        }

        private void SetMaxStepAngle_Click(object sender, EventArgs e)
        {
            float maxStepAngle;
            if (float.TryParse(MaxStepAngleBox.Text, out maxStepAngle)) 
                Settings.Step.MaxAngle = NormiceMod(maxStepAngle, 360) - 180;
            MaxStepAngleBox.Text = Settings.Step.MaxAngle.ToString();
            Settings.Step.MinAngle = Math.Min(Settings.Step.MinAngle, Settings.Step.MaxAngle);
            MinStepAngleBox.Text = Settings.Step.MinAngle.ToString();
        }

        private void SetMinStepAngle_Click(object sender, EventArgs e)
        {
            float minStepAngle;
            if (float.TryParse(MinStepAngleBox.Text, out minStepAngle)) 
                Settings.Step.MinAngle = NormiceMod(minStepAngle, 360) - 180;
            MinStepAngleBox.Text = Settings.Step.MinAngle.ToString();
            Settings.Step.MaxAngle = Math.Max(Settings.Step.MinAngle, Settings.Step.MaxAngle);
            MaxStepAngleBox.Text = Settings.Step.MaxAngle.ToString();
        }

        private void SetMaxStepLength_Click(object sender, EventArgs e)
        {
            
        }

        private void SetMinStepLength_Click(object sender, EventArgs e)
        {
            
        }
    }
      
    struct SimulationSettings
    {
        public FeromonEx Feromon;
        public StepEx Step;
        public SensorEx Sensor;
        public MadnessEx Madness;
        public int VisualisationGradientNumber { get; set; }
    }
    public struct FeromonEx
    {
        public float Emission { get; set; }
        public float Volatilization { get; set; }
        public float Diffusion { get; set; }
    }
    public struct SensorEx
    {
        public float MaxLength { get; set; }
        public float MinLength { get; set; }
        public float MaxAngle { get; set; }
        public float MinAngle { get; set; }
    }
    public struct StepEx
    {
        public float NecessaryTurn { get; set; }
        public float Wobbling { get; set; }
        public float MaxLength { get; set; }
        public float MinLength { get; set; }
        public float MaxAngle { get; set; }
        public float MinAngle { get; set; }

        public void Rand()
        {
            Random rand = new Random();
            
            NecessaryTurn = 3700 / ((float)rand.NextDouble() * 360 + 10) - 190;
            Wobbling = 3700 / ((float)rand.NextDouble() * 360 + 10) - 190;
            Diapazone diapazone = new Diapazone(rand.NextDouble() * 5 + 5, rand.NextDouble() * 5);
            MaxLength = (float)rand.NextDouble();
            MinLength = (float)rand.NextDouble();
            MaxAngle = (float)rand.NextDouble();
            MinAngle = (float)rand.NextDouble();
        }
    }
    public struct MadnessEx
    {
        public int MaxTime {  get; set; }
        public int MinTime { get; set; }
        public int MaxThreshold { get; set; }
        public int MinThreshold { get; set; }
    }
}