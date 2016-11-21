// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using TOM = Microsoft.AnalysisServices.Tabular;

namespace TabularEditor.TOMWrapper
{
  
    /// <summary>
	/// Base class declaration for CalculatedColumn
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public partial class CalculatedColumn: Column, IExpressionObject
	{
	    protected internal new TOM.CalculatedColumn MetadataObject { get { return base.MetadataObject as TOM.CalculatedColumn; } internal set { base.MetadataObject = value; } }

		public CalculatedColumn(Table parent) : base(parent.Handler, new TOM.CalculatedColumn(), false) {
			MetadataObject.Name = parent.MetadataObject.Columns.GetNewName("New CalculatedColumn");
			parent.Columns.Add(this);
			Init();
		}

		public CalculatedColumn(TabularModelHandler handler, TOM.CalculatedColumn calculatedcolumnMetadataObject) : base(handler, calculatedcolumnMetadataObject)
		{
		}
        /// <summary>
        /// Gets or sets the IsDataTypeInferred of the CalculatedColumn.
        /// </summary>
		[DisplayName("Data Type Inferred")]
		[Category("Other"),IntelliSense("The Data Type Inferred of this CalculatedColumn.")]
		public bool IsDataTypeInferred {
			get {
			    return MetadataObject.IsDataTypeInferred;
			}
			set {
				var oldValue = IsDataTypeInferred;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsDataTypeInferred", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsDataTypeInferred = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsDataTypeInferred", oldValue, value));
				OnPropertyChanged("IsDataTypeInferred", oldValue, value);
			}
		}
		private bool ShouldSerializeIsDataTypeInferred() { return false; }
        /// <summary>
        /// Gets or sets the Expression of the CalculatedColumn.
        /// </summary>
		[DisplayName("Expression")]
		[Category("Options"),IntelliSense("The Expression of this CalculatedColumn.")]
		public string Expression {
			get {
			    return MetadataObject.Expression;
			}
			set {
				var oldValue = Expression;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Expression", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Expression = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Expression", oldValue, value));
				OnPropertyChanged("Expression", oldValue, value);
			}
		}
		private bool ShouldSerializeExpression() { return false; }
    }
}
