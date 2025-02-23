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
    public partial class Physarum : Form
    {
        SimulationSettings Settings = new SimulationSettings();
        public Physarum()
        {
            InitializeComponent();
        }
        
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
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

        private void SetWobbling_Click(object sender, EventArgs e)
        {
            Single.TryParse(WobblingBox.Text, out Settings.Step.Wobbling);
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
        public int MinAngle { get; set; }
    }
    public struct MadnessEx
    {
        public int MaxTime {  get; set; }
        public int MinTime { get; set; }
        public int MaxThreshold { get; set; }
        public int MinThreshold { get; set; }
    }
}
