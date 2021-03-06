﻿using System;

namespace Diplo.TraceLogViewer.Models
{
	/// <summary>
	/// Represents a log file item (date and path)
	/// </summary>
	public class LogFileItem
	{
		/// <summary>
		/// Get the date of the log file
		/// </summary>
		public DateTime Date { get; private set; }

		/// <summary>
		/// Get the full path to the log file
		/// </summary>
		public string Path { get; private set; }

        /// <summary>
        /// Gets just the file name of the log file
        /// </summary>
        public string Filename { get { return System.IO.Path.GetFileName(this.Path); } }

        /// <summary>
        /// Instantiate a new log item from the date and path
        /// </summary>
        /// <param name="date">The log file date</param>
        /// <param name="path">The log file relative path</param>
		public LogFileItem(DateTime date, string path)
		{
			this.Date = date;
			this.Path = path;
		}

        public override string ToString()
        {
            return String.Format("{0:yyyy-MM-dd} - {1} [{2}]", this.Date, this.Filename);
        }
    }
}
