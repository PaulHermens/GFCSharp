using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Foundation {
	public partial class GUI : Form {
		private Renderer renderer;

		public GUI() {
			InitializeComponent();

			renderer = new Renderer(ref graphicsPanel);
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e) {
			renderer.Stop();
		}

		private void OnResizeEnd(object sender, EventArgs e) {
			renderer.ReInit();
		}
	}
}
