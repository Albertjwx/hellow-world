using Smobiler.Core;

namespace SmobilerApplication1
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.buttonBlueState = new Smobiler.Core.Controls.Button();
            this.buttonOpenBlue = new Smobiler.Core.Controls.Button();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // buttonBlueState
            // 
            this.buttonBlueState.Location = new System.Drawing.Point(100, 45);
            this.buttonBlueState.Name = "buttonBlueState";
            this.buttonBlueState.Size = new System.Drawing.Size(100, 30);
            this.buttonBlueState.Text = "获取蓝牙状态";
            this.buttonBlueState.Press += new System.EventHandler(this.buttonBlueState_Press);
            // 
            // buttonOpenBlue
            // 
            this.buttonOpenBlue.Location = new System.Drawing.Point(100, 120);
            this.buttonOpenBlue.Name = "buttonOpenBlue";
            this.buttonOpenBlue.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenBlue.Text = "打开蓝牙界面";
            this.buttonOpenBlue.Press += new System.EventHandler(this.buttonOpenBlue_Press);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "打开蓝牙界面";
            this.button1.Press += new System.EventHandler(this.buttonOpenBlue_Press);
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.buttonBlueState,
            this.buttonOpenBlue,
            this.button1});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Button buttonBlueState;
        private Smobiler.Core.Controls.Button buttonOpenBlue;
        private Smobiler.Core.Controls.Button button1;
    }
}