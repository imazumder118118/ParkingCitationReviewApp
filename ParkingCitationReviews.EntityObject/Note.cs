using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace ParkingCitationReviews.EntityObjects
{
    public class Note
    {
        /// <summary>
        ///  Private member field containing note ID
        /// </summary>
        private int noteID;

        /// <summary>
        ///  Private member field containing the review number of the citation review to which the note is attached
        /// </summary>
        private int reviewNum;

        /// <summary>
        ///  Private member field containing the note's text
        /// </summary>
        private string noteText;

        /// <summary>
        ///  Private member field containing the user ID of the person entering the note
        /// </summary>
        private int noteByID;

        /// <summary>
        ///  Private member field containing the name of the person entering the note
        /// </summary>
        private string noteByName;

        /// <summary>
        ///  Private member field containing the date the note is entered or updated
        /// </summary>
        private DateTime noteDate;

        /// <summary>
        ///  Private member field containing the type of note - either "User" or "System"
        /// </summary>
        private string noteType;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Note class with no input parameters
        /// </summary>
        public Note()
        {
        }

        /// <summary>
        ///  Gets or sets the value for the note ID
        /// </summary>
        public int NoteID
        {
            get
            {
                return this.noteID;
            }

            set
            {
                this.noteID = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for the review number of the citation review to which the note is attached
        /// </summary>
        public int ReviewNum
        {
            get
            {
                return this.reviewNum;
            }

            set
            {
                this.reviewNum = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for the note's text
        /// </summary>
        public string NoteText
        {
            get
            {
                return this.noteText;
            }

            set
            {
                this.noteText = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for the user ID of the person entering the note
        /// </summary>
        public int NoteByID
        {
            get
            {
                return this.noteByID;
            }

            set
            {
                this.noteByID = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for the name of the person entering the note
        /// </summary>
        public string NoteByName
        {
            get
            {
                return this.noteByName;
            }

            set
            {
                this.noteByName = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for the date the note is entered or updated
        /// </summary>
        public DateTime NoteDate
        {
            get
            {
                return this.noteDate;
            }

            set
            {
                this.noteDate = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for the type of note - either "User" or "System"
        /// </summary>
        public string NoteType
        {
            get
            {
                return this.noteType;
            }

            set
            {
                this.noteType = value;
            }
        }
        #endregion
    }
}

