using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCFClient
{
    public partial class fmMain : Form
    {
        #region Constructors

        public fmMain()
        {
            InitializeComponent();
            _client = new WCFService.WCFServiceClient("BasicHttpBinding_IWCFService");
        }

        #endregion Constructors

        #region Events

        #endregion Events

        #region Variables

        private WCFService.WCFServiceClient _client;

        #endregion Variables

        #region Fields

        #endregion Fields

        #region Properties

        #endregion Properties

        #region Methods

        #endregion Methods

        #region EventHandlers

        #endregion EventHandlers

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int y;

            if (int.TryParse(textBox1.Text, out x) && int.TryParse(textBox2.Text, out y))
                label1.Text = _client.GetSum(x, y).ToString();
        }
    }
}
