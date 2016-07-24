﻿using System.ComponentModel.DataAnnotations;

namespace Dopamine.Core.Database.Entities
{
    public class Folder
    {
        #region Properties
        [Key()]
        public long FolderID { get; set; }
        public string Path { get; set; }
        public long ShowInCollection { get; set; }
        #endregion
    }
}