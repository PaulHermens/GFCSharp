namespace Game_Foundation {
	partial class GUI {
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.graphicsPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// graphicsPanel
			// 
			this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.graphicsPanel.Location = new System.Drawing.Point(0, 0);
			this.graphicsPanel.Name = "graphicsPanel";
			this.graphicsPanel.Size = new System.Drawing.Size(984, 561);
			this.graphicsPanel.TabIndex = 0;
			// 
			// GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.graphicsPanel);
			this.MaximizeBox = false;
			this.Name = "GUI";
			this.ShowIcon = false;
			this.Text = "Game Foundation";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.ResizeEnd += new System.EventHandler(this.OnResizeEnd);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel graphicsPanel;
	}
}

