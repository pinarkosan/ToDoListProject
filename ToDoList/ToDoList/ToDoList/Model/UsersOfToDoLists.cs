//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoList.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersOfToDoLists
    {
        public int UserListId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> ListId { get; set; }
    
        public virtual TodoLists TodoLists { get; set; }
        public virtual Users Users { get; set; }
    }
}