// // Breeze Project
// // Created by Bartosz Rachwal. 
// // Copyright (c) 2016 Bartosz Rachwal. The National Institute of Advanced Industrial Science and Technology, Japan. All rights reserved.

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof (DataTable.Startup))]

namespace DataTable
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}