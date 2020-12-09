using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlanetsDatabase
{
    /// <summary>
    /// Central class of the program where everything happens
    /// </summary>
    class Motor
    {
        private AccessFile file;

        private ScreenInfoText printText;

        private InputContent inputCont;

        /// <summary>
        /// Used to initialize variables
        /// </summary>
        public Motor()
        {
            file = new AccessFile();

            printText = new ScreenInfoText();

            inputCont = new InputContent();
        }

        public void ExecuteProg()
        {
            printText.IntroMenu();

            file.AccessTheFile();

            //printText.MainMenu();

            ////////////////////// SEND FILE TO INPUT CONTENT
            //inputCont.MainMenuInput(file);
        }
    }
}