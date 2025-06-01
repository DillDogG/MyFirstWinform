using MyFirstWinform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinform
{
    interface sectionGuessState
    {
        private static Image image = Properties.Resources.Incorrect_Guess;
        string returnCurrentState();
        Image returnCurrentImage();
    }

    class NoState : sectionGuessState
    {
        private static Image image = Properties.Resources.Incorrect_Guess;

        public string returnCurrentState()
        {
            return "No Guess Here";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class IncorrectState : sectionGuessState
    {
        private static Image image = Properties.Resources.Incorrect_Guess;

        public string returnCurrentState()
        {
            return "INCORRECT";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class CloseState : sectionGuessState
    {
        private static Image image = Properties.Resources.Close_Guess;

        public string returnCurrentState()
        {
            return "CLOSE";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class CorrectState : sectionGuessState
    {
        public static Image image = Properties.Resources.Correct_Guess;

        public string returnCurrentState()
        {
            return "CORRECT";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class WinState : sectionGuessState
    {
        private static Image image = Properties.Resources.Player_Wins;

        public string returnCurrentState()
        {
            return "YOU WIN";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class OutOfGuessesState : sectionGuessState
    {
        private static Image image = Properties.Resources.Player_Loses;

        public string returnCurrentState()
        {
            return "YOU LOSE";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class sectionGuessContext
    {
        public sectionGuessState state = new NoState();

        public void setState(sectionGuessState state)
        {
            this.state = state;
        }

        public string request()
        {
            return state.returnCurrentState();
        }

        public Image getImage()
        {
            return state.returnCurrentImage();
        }
    }
}
