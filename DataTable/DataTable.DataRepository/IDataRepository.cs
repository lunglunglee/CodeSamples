// // Breeze Project
// // Created by Bartosz Rachwal. 
// // Copyright (c) 2016 Bartosz Rachwal. The National Institute of Advanced Industrial Science and Technology, Japan. All rights reserved.

using System.Collections.Generic;

namespace DataTable.DataRepository
{
    public interface IDataRepository
    {
        List<DataTableEntry> Search(string searchText);
    }
}