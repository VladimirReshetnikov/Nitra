﻿using System.ComponentModel.Composition;
using System.Windows.Media;
using JetBrains.TextControl.DocumentMarkup;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
// ReSharper disable UnassignedField.Global

[assembly: RegisterHighlighter(
  id: XNamespaceX.XxxClassificationDefinition.Name,
  EffectColor = "Red",
  EffectType = EffectType.TEXT,
  Layer = HighlighterLayer.SYNTAX,
  VSPriority = VSPriority.IDENTIFIERS)]

namespace XNamespaceX
{
  [ClassificationType(ClassificationTypeNames = Name)]
  [Order(After = "Formal Language Priority", Before = "Natural Language Priority")]
  [Export(typeof(EditorFormatDefinition))]
  [Name(Name)]
  [DisplayName(Name)]
  [UserVisible(true)]
  internal class XxxClassificationDefinition : ClassificationFormatDefinition
  {
    public const string Name = "XDisplay nameX";

    public XxxClassificationDefinition()
    {
      DisplayName = Name;
      ForegroundColor = Colors.Red;
    }

    [Export, Name(Name), BaseDefinition("formal language")]
    internal ClassificationTypeDefinition ClassificationTypeDefinition;
  }
}