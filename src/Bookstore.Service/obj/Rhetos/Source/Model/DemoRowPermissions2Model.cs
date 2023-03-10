// <autogenerated />
namespace DemoRowPermissions2
{
    #pragma warning disable // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using DemoRowPermissions2*/

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.Division*/
    public class Division : EntityBase<DemoRowPermissions2.Division>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.Division*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.Division.Name*/
        public string Name { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.Division.RegionID*/
        public Guid? RegionID { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.Division*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.Document*/
    public class Document : EntityBase<DemoRowPermissions2.Document>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.Document*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.Document.Created*/
        public DateTime? Created { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.Document.DivisionID*/
        public Guid? DivisionID { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.Document.Title*/
        public string Title { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.Document*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.DocumentApproval*/
    public class DocumentApproval : EntityBase<DemoRowPermissions2.DocumentApproval>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.DocumentApproval*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.DocumentApproval.Note*/
        public string Note { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.DocumentApproval.ApprovedByID*/
        public Guid? ApprovedByID { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.DocumentApproval*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.DocumentComment*/
    public class DocumentComment : EntityBase<DemoRowPermissions2.DocumentComment>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.DocumentComment*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.DocumentComment.Comment*/
        public string Comment { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.DocumentComment.DocumentID*/
        public Guid? DocumentID { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.DocumentComment*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.DocumentInfo*/
    public class DocumentInfo : EntityBase<DemoRowPermissions2.DocumentInfo>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.DocumentInfo*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.DocumentInfo.Division2ID*/
        public Guid? Division2ID { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.DocumentInfo.Title2*/
        public string Title2 { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.DocumentInfo*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.Employee*/
    public class Employee : EntityBase<DemoRowPermissions2.Employee>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.Employee*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.Employee.DivisionID*/
        public Guid? DivisionID { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.Employee.UserName*/
        public string UserName { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.Employee*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.Region*/
    public class Region : EntityBase<DemoRowPermissions2.Region>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.Region*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.Region.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.Region*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.RegionSupervisor*/
    public class RegionSupervisor : EntityBase<DemoRowPermissions2.RegionSupervisor>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.RegionSupervisor*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.RegionSupervisor.EmployeeID*/
        public Guid? EmployeeID { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.RegionSupervisor.RegionID*/
        public Guid? RegionID { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.RegionSupervisor*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.SystemRequiredDocument*/
    public class SystemRequiredDocument/*DataStructureInfo ClassInterace DemoRowPermissions2.SystemRequiredDocument*/
    {
        /*DataStructureInfo ClassBody DemoRowPermissions2.SystemRequiredDocument*/
    }

    /*DataStructureInfo ClassAttributes DemoRowPermissions2.DocumentBrowse*/
    public class DocumentBrowse : EntityBase<DemoRowPermissions2.DocumentBrowse>/*Next DataStructureInfo ClassInterace DemoRowPermissions2.DocumentBrowse*/
    {
        /*PropertyInfo Attribute DemoRowPermissions2.DocumentBrowse.DivisionName*/
        public string DivisionName { get; set; }
        /*PropertyInfo Attribute DemoRowPermissions2.DocumentBrowse.Title*/
        public string Title { get; set; }
        /*DataStructureInfo ClassBody DemoRowPermissions2.DocumentBrowse*/
    }

    /*ModuleInfo Body DemoRowPermissions2*/

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}

namespace Common.Queryable
{
    #pragma warning disable // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.Division*/
    public class DemoRowPermissions2_Division : global::DemoRowPermissions2.Division, IQueryableEntity<DemoRowPermissions2.Division>, System.IEquatable<DemoRowPermissions2_Division>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.Division*/
    {
        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.Division.Region*/
        public virtual Common.Queryable.DemoRowPermissions2_Region Region { get; init; }

        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.Division*/

        public bool Equals(DemoRowPermissions2_Division other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.Division ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.Division
            {
                ID = item.ID,
                Name = item.Name,
                RegionID = item.RegionID/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.Division*/
            };
        }
    }

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.Document*/
    public class DemoRowPermissions2_Document : global::DemoRowPermissions2.Document, IQueryableEntity<DemoRowPermissions2.Document>, System.IEquatable<DemoRowPermissions2_Document>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.Document*/
    {
        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.Document.Division*/
        public virtual Common.Queryable.DemoRowPermissions2_Division Division { get; init; }

        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.Document.Extension_DocumentApproval*/
        public virtual Common.Queryable.DemoRowPermissions2_DocumentApproval Extension_DocumentApproval { get; init; }

        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.Document.Extension_DocumentInfo*/
        public virtual Common.Queryable.DemoRowPermissions2_DocumentInfo Extension_DocumentInfo { get; init; }

        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.Document.Extension_DocumentBrowse*/
        public virtual Common.Queryable.DemoRowPermissions2_DocumentBrowse Extension_DocumentBrowse { get; init; }

        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.Document*/

        public bool Equals(DemoRowPermissions2_Document other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.Document ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.Document
            {
                ID = item.ID,
                Created = item.Created,
                DivisionID = item.DivisionID,
                Title = item.Title/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.Document*/
            };
        }
    }

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.DocumentApproval*/
    public class DemoRowPermissions2_DocumentApproval : global::DemoRowPermissions2.DocumentApproval, IQueryableEntity<DemoRowPermissions2.DocumentApproval>, System.IEquatable<DemoRowPermissions2_DocumentApproval>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.DocumentApproval*/
    {
        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.DocumentApproval.Base*/
        public virtual Common.Queryable.DemoRowPermissions2_Document Base { get; init; }

        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.DocumentApproval.ApprovedBy*/
        public virtual Common.Queryable.DemoRowPermissions2_Employee ApprovedBy { get; init; }

        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.DocumentApproval*/

        public bool Equals(DemoRowPermissions2_DocumentApproval other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.DocumentApproval ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.DocumentApproval
            {
                ID = item.ID,
                Note = item.Note,
                ApprovedByID = item.ApprovedByID/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.DocumentApproval*/
            };
        }
    }

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.DocumentComment*/
    public class DemoRowPermissions2_DocumentComment : global::DemoRowPermissions2.DocumentComment, IQueryableEntity<DemoRowPermissions2.DocumentComment>, System.IEquatable<DemoRowPermissions2_DocumentComment>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.DocumentComment*/
    {
        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.DocumentComment.Document*/
        public virtual Common.Queryable.DemoRowPermissions2_Document Document { get; init; }

        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.DocumentComment*/

        public bool Equals(DemoRowPermissions2_DocumentComment other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.DocumentComment ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.DocumentComment
            {
                ID = item.ID,
                Comment = item.Comment,
                DocumentID = item.DocumentID/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.DocumentComment*/
            };
        }
    }

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.DocumentInfo*/
    public class DemoRowPermissions2_DocumentInfo : global::DemoRowPermissions2.DocumentInfo, IQueryableEntity<DemoRowPermissions2.DocumentInfo>, System.IEquatable<DemoRowPermissions2_DocumentInfo>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.DocumentInfo*/
    {
        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.DocumentInfo.Division2*/
        public virtual Common.Queryable.DemoRowPermissions2_Division Division2 { get; init; }

        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.DocumentInfo.Base*/
        public virtual Common.Queryable.DemoRowPermissions2_Document Base { get; init; }

        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.DocumentInfo*/

        public bool Equals(DemoRowPermissions2_DocumentInfo other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.DocumentInfo ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.DocumentInfo
            {
                ID = item.ID,
                Division2ID = item.Division2ID,
                Title2 = item.Title2/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.DocumentInfo*/
            };
        }
    }

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.Employee*/
    public class DemoRowPermissions2_Employee : global::DemoRowPermissions2.Employee, IQueryableEntity<DemoRowPermissions2.Employee>, System.IEquatable<DemoRowPermissions2_Employee>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.Employee*/
    {
        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.Employee.Division*/
        public virtual Common.Queryable.DemoRowPermissions2_Division Division { get; init; }

        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.Employee*/

        public bool Equals(DemoRowPermissions2_Employee other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.Employee ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.Employee
            {
                ID = item.ID,
                DivisionID = item.DivisionID,
                UserName = item.UserName/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.Employee*/
            };
        }
    }

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.Region*/
    public class DemoRowPermissions2_Region : global::DemoRowPermissions2.Region, IQueryableEntity<DemoRowPermissions2.Region>, System.IEquatable<DemoRowPermissions2_Region>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.Region*/
    {
        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.Region*/

        public bool Equals(DemoRowPermissions2_Region other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.Region ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.Region
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.Region*/
            };
        }
    }

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.RegionSupervisor*/
    public class DemoRowPermissions2_RegionSupervisor : global::DemoRowPermissions2.RegionSupervisor, IQueryableEntity<DemoRowPermissions2.RegionSupervisor>, System.IEquatable<DemoRowPermissions2_RegionSupervisor>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.RegionSupervisor*/
    {
        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.RegionSupervisor.Employee*/
        public virtual Common.Queryable.DemoRowPermissions2_Employee Employee { get; init; }

        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.RegionSupervisor.Region*/
        public virtual Common.Queryable.DemoRowPermissions2_Region Region { get; init; }

        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.RegionSupervisor*/

        public bool Equals(DemoRowPermissions2_RegionSupervisor other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.RegionSupervisor ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.RegionSupervisor
            {
                ID = item.ID,
                EmployeeID = item.EmployeeID,
                RegionID = item.RegionID/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.RegionSupervisor*/
            };
        }
    }

    /*DataStructureInfo QueryableClassAttributes DemoRowPermissions2.DocumentBrowse*/
    public class DemoRowPermissions2_DocumentBrowse : global::DemoRowPermissions2.DocumentBrowse, IQueryableEntity<DemoRowPermissions2.DocumentBrowse>, System.IEquatable<DemoRowPermissions2_DocumentBrowse>/*DataStructureInfo QueryableClassInterace DemoRowPermissions2.DocumentBrowse*/
    {
        /*DataStructureQueryable PropertyAttribute DemoRowPermissions2.DocumentBrowse.Base*/
        public virtual Common.Queryable.DemoRowPermissions2_Document Base { get; init; }

        /*DataStructureInfo QueryableClassMembers DemoRowPermissions2.DocumentBrowse*/

        public bool Equals(DemoRowPermissions2_DocumentBrowse other)
        {
            return other != null && other.ID == ID;
        }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public DemoRowPermissions2.DocumentBrowse ToSimple()
        {
            var item = this;
            return new DemoRowPermissions2.DocumentBrowse
            {
                ID = item.ID,
                DivisionName = item.DivisionName,
                Title = item.Title/*DataStructureInfo AssignSimpleProperty DemoRowPermissions2.DocumentBrowse*/
            };
        }
    }

    /*ModuleInfo CommonQueryableMemebers DemoRowPermissions2*/

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}
