using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Forms
{
    public class BasketballPlayerGameStat
    {
        private string _playername;
        private int _fieldgoalattempts;
        private int _fieldgoalsmade;
        private int _freethrowattempts;
        private int _freethrowsmade;
        private int _personalfouls;
        private int _technicalfouls;

        public BasketballPlayerGameStat()
        {
            _playername = "";
            _fieldgoalattempts = 0;
            _fieldgoalsmade = 0;
            _freethrowattempts = 0;
            _freethrowsmade = 0;
            _personalfouls = 0;
            _technicalfouls = 0;
        }

        public string PlayerName
        {
            get { return _playername; }
            set
            {
                if (value != _playername)
                {
                    _playername = value;
                }
            }
        }

        public int FieldGoalsAttempted
        {
            get { return _fieldgoalattempts; }
            set
            {
                if (value != _fieldgoalattempts)
                {
                    _fieldgoalattempts = value;
                }
            }
        }

        public int FieldGoalsMade
        {
            get { return _fieldgoalsmade; }
            set
            {
                if (value != _fieldgoalsmade)
                {
                    _fieldgoalsmade = value;
                }
            }
        }

        public int FreeThrowAttempts
        {
            get { return _freethrowattempts; }
            set
            {
                if (value != _freethrowattempts)
                {
                    _freethrowattempts = value;
                }
            }
        }

        public int FreeThrowsMade
        {
            get { return _freethrowsmade; }
            set
            {
                if (value != _freethrowsmade)
                {
                    _freethrowsmade = value;
                }
            }
        }

        public int PersonalFouls
        {
            get { return _personalfouls; }
            set
            {
                if (value != _personalfouls)
                {
                    _personalfouls = value;
                }
            }
        }

        public int TechnicalFouls
        {
            get { return _technicalfouls; }
            set
            {
                if (value != _technicalfouls)
                {
                    _technicalfouls = value;
                }
            }
        }

    }
}
