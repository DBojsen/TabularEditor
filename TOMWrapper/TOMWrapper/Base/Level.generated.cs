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
	/// Base class declaration for Level
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public partial class Level: TabularNamedObject, IDescriptionObject
	{
	    protected internal new TOM.Level MetadataObject { get { return base.MetadataObject as TOM.Level; } internal set { base.MetadataObject = value; } }

		public Level(Hierarchy parent) : base(parent.Handler, new TOM.Level(), false) {
			MetadataObject.Name = parent.MetadataObject.Levels.GetNewName("New Level");
			parent.Levels.Add(this);
			Init();
		}

		public Level(TabularModelHandler handler, TOM.Level levelMetadataObject) : base(handler, levelMetadataObject)
		{
		}
        /// <summary>
        /// Gets or sets the Ordinal of the Level.
        /// </summary>
		[DisplayName("Ordinal")]
		[Category("Other"),IntelliSense("The Ordinal of this Level.")][NoMultiselect()]
		public int Ordinal {
			get {
			    return MetadataObject.Ordinal;
			}
			set {
				var oldValue = Ordinal;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Ordinal", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Ordinal = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Ordinal", oldValue, value));
				OnPropertyChanged("Ordinal", oldValue, value);
			}
		}
		private bool ShouldSerializeOrdinal() { return false; }
        /// <summary>
        /// Gets or sets the Description of the Level.
        /// </summary>
		[DisplayName("Description")]
		[Category("Basic"),IntelliSense("The Description of this Level.")]
		public string Description {
			get {
			    return MetadataObject.Description;
			}
			set {
				var oldValue = Description;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Description", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Description = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Description", oldValue, value));
				OnPropertyChanged("Description", oldValue, value);
			}
		}
		private bool ShouldSerializeDescription() { return false; }
        /// <summary>
        /// Collection of localized descriptions for this Level.
        /// </summary>
        [Browsable(true),DisplayName("Descriptions"),Category("Translations and Perspectives")]
	    public new TranslationIndexer TranslatedDescriptions { get { return base.TranslatedDescriptions; } }
        /// <summary>
        /// Gets or sets the Hierarchy of the Level.
        /// </summary>
		[DisplayName("Hierarchy")]
		[Category("Other"),IntelliSense("The Hierarchy of this Level.")][Browsable(false)]
		public Hierarchy Hierarchy {
			get {
				if (MetadataObject.Hierarchy == null) return null;
			    return Handler.WrapperLookup[MetadataObject.Hierarchy] as Hierarchy;
            }
			
		}
		private bool ShouldSerializeHierarchy() { return false; }
        /// <summary>
        /// Gets or sets the Column of the Level.
        /// </summary>
		[DisplayName("Column")]
		[Category("Other"),IntelliSense("The Column of this Level.")][TypeConverter(typeof(HierarchyColumnConverter)),NoMultiselect()]
		public Column Column {
			get {
				if (MetadataObject.Column == null) return null;
			    return Handler.WrapperLookup[MetadataObject.Column] as Column;
            }
			set {
				var oldValue = Column;
				if (oldValue?.MetadataObject == value?.MetadataObject) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Column", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Column = value?.MetadataObject;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Column", oldValue, value));
				OnPropertyChanged("Column", oldValue, value);
			}
		}
		private bool ShouldSerializeColumn() { return false; }
    }

	/// <summary>
	/// Collection class for Level. Provides convenient properties for setting a property on multiple objects at once.
	/// </summary>
	public partial class LevelCollection: TabularObjectCollection<Level, TOM.Level, TOM.Hierarchy>
	{
		public LevelCollection(TabularModelHandler handler, string collectionName, TOM.LevelCollection metadataObjectCollection) : base(handler, collectionName, metadataObjectCollection)
		{
			// Construct child objects (they are automatically added to the Handler's WrapperLookup dictionary):
			foreach(var obj in MetadataObjectCollection) {
				new Level(handler, obj) { Collection = this };
			}
		}

		[Description("Sets the Description property of all objects in the collection at once.")]
		public string Description {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("Description"));
				this.ToList().ForEach(item => { item.Description = value; });
				Handler.UndoManager.EndBatch();
			}
		}

		public override string ToString() {
			return string.Format("({0} {1})", Count, (Count == 1 ? "Level" : "Levels").ToLower());
		}
	}
}
