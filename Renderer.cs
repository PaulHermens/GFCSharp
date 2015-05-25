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
		private Panel parent;
		private Thread runningThread;

		private short exitCode;
		private bool running = true;

		//Constructor of Renderer class
		public Renderer(ref Panel panel) {
			if (panel != null) {
				graphics = panel.CreateGraphics();
				parent = panel;
			}

			InitThread();
		}

		public void ReInit() {
			Stop();

			//Creating a new graphics object
			graphics.Dispose();
			graphics = parent.CreateGraphics();
			
			//Rerun the thread
			InitThread();
		}

		private void InitThread() {
			if (runningThread == null || (!running && !runningThread.IsAlive)) {
				running = true;
				exitCode = -1;

				runningThread = new Thread(new ThreadStart(Run));
				runningThread.Priority = ThreadPriority.Highest;
				runningThread.Start();
			}
		}
		
		//The main game loop
		private void Run() {
			ushort fps = 0;
			uint currentTime = (uint)DateTime.Now.Ticks / 10000, endTime = currentTime + 1000;

			while (running) {
				//Clearing the picture
				graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, parent.Width, parent.Height);

				//Counting FPS
				fps++;
				currentTime = (uint)DateTime.Now.Ticks / 10000;
				if (currentTime >= endTime) {
					Console.WriteLine("FPS: " + fps);
					endTime = currentTime + 1000;
					fps = 0;
				}
			}
			exitCode = 0;
		}

		//Stops the thread and waits for it to terminate
		public void Stop() {
			running = false;
			while (exitCode != 0) {
				Thread.Sleep(10);
			}
			runningThread.Abort();
		}
	}
}