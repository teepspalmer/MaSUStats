using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Forms
{
    public class Player
    {
        protected int _playerid;
        protected string _firstname;
        protected string _lastname;
        protected string _gender;
        protected DateTime _dob;
        protected string _homestate;
        protected string _hometown;

        public Player()
        {
            _playerid = 0;
            _firstname = "";
            _lastname = "";
            _gender = "";
            _dob = DateTime.MinValue;
            _homestate = "";
            _hometown = "";
        }

        public int PlayerID
        {
            get { return _playerid; }
            set
            {
                if (value != _playerid)
                {
                    _playerid = value;
                }
            }
        }

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                if (value != _firstname)
                {
                    _firstname = value;
                }
            }
        }

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (value != _lastname)
                {
                    _lastname = value;
                }
            }
        }

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value != _gender)
                {
                    _gender = value;
                }
            }
        }

        public DateTime DateOfBirth
        {
            get { return _dob; }
            set
            {
                if (value != _dob)
                {
                    _dob = value;
                }
            }
        }

        public string HomeState
        {
            get { return _homestate; }
            set
            {
                if (value != _homestate)
                {
                    _homestate = value;
                }
            }
        }

        public string HomeTown
        {
            get { return _hometown; }
            set
            {
                if (value != _hometown)
                {
                    _hometown = value;
                }
            }
        }
    }
}
