// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Spreadsheet
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;


    [Serializable]
    //[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_CommentList
    {

        private List<CT_Comment> commentField = null; // optional field [0..*]

        //public CT_CommentList()
        //{
        //    this.commentField = new List<CT_Comment>();
        //}

        public CT_Comment GetCommentArray(int index)
        {
            return comment[index];
        }
        public void RemoveComment(int index)
        {
            comment.RemoveAt(index);
        }
        public int SizeOfCommentArray()
        {
            return comment.Count;
        }
        public CT_Comment InsertNewComment(int index)
        {
            if (null == commentField) { commentField = new List<CT_Comment>(); }
            CT_Comment com = new CT_Comment();
            commentField.Insert(index,com);
            return com;            
        }
        public CT_Comment AddNewComment()
        {
            if (null == commentField) { commentField = new List<CT_Comment>(); }
            CT_Comment com= new CT_Comment();
            commentField.Add(com);
            return com;
        }

        [XmlElement("comment")]
        public List<CT_Comment> comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }
}
