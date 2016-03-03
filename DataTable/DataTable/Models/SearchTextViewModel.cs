// // Breeze Project
// // Created by Bartosz Rachwal. 
// // Copyright (c) 2016 Bartosz Rachwal. The National Institute of Advanced Industrial Science and Technology, Japan. All rights reserved.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataTable.DataRepository;

namespace DataTable.Models
{
    public class SearchTextViewModel
    {
        [Required]
        [Display(Name = "Search")]
        public string SearchText { get; set; }

        public List<DataTableEntry> Entries { get; set; } = new List<DataTableEntry>();
    }
}