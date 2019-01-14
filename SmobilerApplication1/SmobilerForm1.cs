using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerApplication1
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1() : base()
        {
            InitializeComponent();
        }

        private void buttonBlueState_Press(object sender, EventArgs e)
        {
            try
            {
                this.Client.Bluetooth.IsOpen((object obj, Smobiler.Core.RPC.BluetoothManagerIsOpenArgs args) =>
                {
                    if (args.IsOpen == true)
                        Toast("Open");
                    else
                        Toast("Not Open");
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
            this.Client.Bluetooth.GetHashCode();
        }

        private void buttonOpenBlue_Press(object sender, EventArgs e)
        {
            try
            {
                this.Client.Bluetooth.Show();
            }
            catch(Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}