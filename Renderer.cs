using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Foundation {
	public class Renderer{
		//Rendering variables
		private Graphics graphics;
		private Thread runningThread;
		private bool running = true;

		//Constructor of Renderer class
		public Renderer(Control control) {
			if (control != null)
				graphics = control.CreateGraphics();

			runningThread = new Thread(new ThreadStart(Run));
			runningThread.Start();
		}
		
		//The main game loop
		private void Run() {
			ushort fps = 0;
			uint currentTime = (uint)DateTime.Now.Ticks / 10000, endTime = currentTime + 1000;
			while (running) {
				//Clearing the picture
				graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 1000, 600);

				//Counting FPS
				currentTime = (uint)DateTime.Now.Ticks / 10000;
				fps++;
				if (currentTime >= endTime) {
					Console.WriteLine("FPS: " + fps);
					endTime = currentTime + 1000;
					fps = 0;
				}
			}	
		}

		//Stops the thread and waits for it to terminate
		public void Stop() {
			running = false;
			while (!runningThread.IsAlive)
				Thread.Sleep(10);
		}
	}
}