﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v1.6.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Diet, formula or nutritional supplement request
    /// </summary>
    [FhirType("NutritionRequest", IsResource=true)]
    [DataContract]
    public partial class NutritionRequest : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.NutritionRequest; } }
        [NotMapped]
        public override string TypeName { get { return "NutritionRequest"; } }
        
        /// <summary>
        /// Codes specifying the state of the request. Describes the lifecycle of the nutrition order.
        /// (url: http://hl7.org/fhir/ValueSet/nutrition-request-status)
        /// </summary>
        [FhirEnumeration("NutritionOrderStatus")]
        public enum NutritionOrderStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("proposed"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("draft"), Description("Draft")]
            Draft,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("planned"), Description("Planned")]
            Planned,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("requested"), Description("Requested")]
            Requested,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("active"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("on-hold"), Description("On-Hold")]
            OnHold,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("completed"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("cancelled"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/nutrition-request-status)
            /// </summary>
            [EnumLiteral("entered-in-error"), Description("Entered in Error")]
            EnteredInError,
        }

        [FhirType("OralDietComponent")]
        [DataContract]
        public partial class OralDietComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "OralDietComponent"; } }
            
            /// <summary>
            /// Type of oral diet or diet restrictions that describe what can be consumed orally
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Type
            {
                get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Type;
            
            /// <summary>
            /// Scheduled frequency of diet
            /// </summary>
            [FhirElement("schedule", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Timing> Schedule
            {
                get { if(_Schedule==null) _Schedule = new List<Hl7.Fhir.Model.Timing>(); return _Schedule; }
                set { _Schedule = value; OnPropertyChanged("Schedule"); }
            }
            
            private List<Hl7.Fhir.Model.Timing> _Schedule;
            
            /// <summary>
            /// Required  nutrient modifications
            /// </summary>
            [FhirElement("nutrient", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.NutritionRequest.NutrientComponent> Nutrient
            {
                get { if(_Nutrient==null) _Nutrient = new List<Hl7.Fhir.Model.NutritionRequest.NutrientComponent>(); return _Nutrient; }
                set { _Nutrient = value; OnPropertyChanged("Nutrient"); }
            }
            
            private List<Hl7.Fhir.Model.NutritionRequest.NutrientComponent> _Nutrient;
            
            /// <summary>
            /// Required  texture modifications
            /// </summary>
            [FhirElement("texture", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.NutritionRequest.TextureComponent> Texture
            {
                get { if(_Texture==null) _Texture = new List<Hl7.Fhir.Model.NutritionRequest.TextureComponent>(); return _Texture; }
                set { _Texture = value; OnPropertyChanged("Texture"); }
            }
            
            private List<Hl7.Fhir.Model.NutritionRequest.TextureComponent> _Texture;
            
            /// <summary>
            /// The required consistency of fluids and liquids provided to the patient
            /// </summary>
            [FhirElement("fluidConsistencyType", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> FluidConsistencyType
            {
                get { if(_FluidConsistencyType==null) _FluidConsistencyType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _FluidConsistencyType; }
                set { _FluidConsistencyType = value; OnPropertyChanged("FluidConsistencyType"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _FluidConsistencyType;
            
            /// <summary>
            /// Instructions or additional information about the oral diet
            /// </summary>
            [FhirElement("instruction", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString InstructionElement
            {
                get { return _InstructionElement; }
                set { _InstructionElement = value; OnPropertyChanged("InstructionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _InstructionElement;
            
            /// <summary>
            /// Instructions or additional information about the oral diet
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Instruction
            {
                get { return InstructionElement != null ? InstructionElement.Value : null; }
                set
                {
                if (value == null)
                      InstructionElement = null; 
                    else
                        InstructionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Instruction");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OralDietComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = new List<Hl7.Fhir.Model.CodeableConcept>(Type.DeepCopy());
                    if(Schedule != null) dest.Schedule = new List<Hl7.Fhir.Model.Timing>(Schedule.DeepCopy());
                    if(Nutrient != null) dest.Nutrient = new List<Hl7.Fhir.Model.NutritionRequest.NutrientComponent>(Nutrient.DeepCopy());
                    if(Texture != null) dest.Texture = new List<Hl7.Fhir.Model.NutritionRequest.TextureComponent>(Texture.DeepCopy());
                    if(FluidConsistencyType != null) dest.FluidConsistencyType = new List<Hl7.Fhir.Model.CodeableConcept>(FluidConsistencyType.DeepCopy());
                    if(InstructionElement != null) dest.InstructionElement = (Hl7.Fhir.Model.FhirString)InstructionElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new OralDietComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OralDietComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
                if( !DeepComparable.Matches(Nutrient, otherT.Nutrient)) return false;
                if( !DeepComparable.Matches(Texture, otherT.Texture)) return false;
                if( !DeepComparable.Matches(FluidConsistencyType, otherT.FluidConsistencyType)) return false;
                if( !DeepComparable.Matches(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OralDietComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
                if( !DeepComparable.IsExactly(Nutrient, otherT.Nutrient)) return false;
                if( !DeepComparable.IsExactly(Texture, otherT.Texture)) return false;
                if( !DeepComparable.IsExactly(FluidConsistencyType, otherT.FluidConsistencyType)) return false;
                if( !DeepComparable.IsExactly(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("NutrientComponent")]
        [DataContract]
        public partial class NutrientComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NutrientComponent"; } }
            
            /// <summary>
            /// Type of nutrient that is being modified
            /// </summary>
            [FhirElement("modifier", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Modifier
            {
                get { return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Modifier;
            
            /// <summary>
            /// Quantity of the specified nutrient
            /// </summary>
            [FhirElement("amount", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Amount;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NutrientComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Modifier != null) dest.Modifier = (Hl7.Fhir.Model.CodeableConcept)Modifier.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.SimpleQuantity)Amount.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new NutrientComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NutrientComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NutrientComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("TextureComponent")]
        [DataContract]
        public partial class TextureComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TextureComponent"; } }
            
            /// <summary>
            /// Code to indicate how to alter the texture of the foods, e.g. pureed
            /// </summary>
            [FhirElement("modifier", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Modifier
            {
                get { return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Modifier;
            
            /// <summary>
            /// Concepts that are used to identify an entity that is ingested for nutritional purposes
            /// </summary>
            [FhirElement("foodType", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept FoodType
            {
                get { return _FoodType; }
                set { _FoodType = value; OnPropertyChanged("FoodType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _FoodType;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TextureComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Modifier != null) dest.Modifier = (Hl7.Fhir.Model.CodeableConcept)Modifier.DeepCopy();
                    if(FoodType != null) dest.FoodType = (Hl7.Fhir.Model.CodeableConcept)FoodType.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new TextureComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TextureComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(FoodType, otherT.FoodType)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TextureComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(FoodType, otherT.FoodType)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("SupplementComponent")]
        [DataContract]
        public partial class SupplementComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SupplementComponent"; } }
            
            /// <summary>
            /// Type of supplement product requested
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Product or brand name of the nutritional supplement
            /// </summary>
            [FhirElement("productName", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ProductNameElement
            {
                get { return _ProductNameElement; }
                set { _ProductNameElement = value; OnPropertyChanged("ProductNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ProductNameElement;
            
            /// <summary>
            /// Product or brand name of the nutritional supplement
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string ProductName
            {
                get { return ProductNameElement != null ? ProductNameElement.Value : null; }
                set
                {
                if (value == null)
                      ProductNameElement = null; 
                    else
                        ProductNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("ProductName");
                }
            }
            
            /// <summary>
            /// Scheduled frequency of supplement
            /// </summary>
            [FhirElement("schedule", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Timing> Schedule
            {
                get { if(_Schedule==null) _Schedule = new List<Hl7.Fhir.Model.Timing>(); return _Schedule; }
                set { _Schedule = value; OnPropertyChanged("Schedule"); }
            }
            
            private List<Hl7.Fhir.Model.Timing> _Schedule;
            
            /// <summary>
            /// Amount of the nutritional supplement
            /// </summary>
            [FhirElement("quantity", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Instructions or additional information about the oral supplement
            /// </summary>
            [FhirElement("instruction", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString InstructionElement
            {
                get { return _InstructionElement; }
                set { _InstructionElement = value; OnPropertyChanged("InstructionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _InstructionElement;
            
            /// <summary>
            /// Instructions or additional information about the oral supplement
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Instruction
            {
                get { return InstructionElement != null ? InstructionElement.Value : null; }
                set
                {
                if (value == null)
                      InstructionElement = null; 
                    else
                        InstructionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Instruction");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SupplementComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(ProductNameElement != null) dest.ProductNameElement = (Hl7.Fhir.Model.FhirString)ProductNameElement.DeepCopy();
                    if(Schedule != null) dest.Schedule = new List<Hl7.Fhir.Model.Timing>(Schedule.DeepCopy());
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.SimpleQuantity)Quantity.DeepCopy();
                    if(InstructionElement != null) dest.InstructionElement = (Hl7.Fhir.Model.FhirString)InstructionElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SupplementComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SupplementComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(ProductNameElement, otherT.ProductNameElement)) return false;
                if( !DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SupplementComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(ProductNameElement, otherT.ProductNameElement)) return false;
                if( !DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("EnteralFormulaComponent")]
        [DataContract]
        public partial class EnteralFormulaComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "EnteralFormulaComponent"; } }
            
            /// <summary>
            /// Type of enteral or infant formula
            /// </summary>
            [FhirElement("baseFormulaType", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept BaseFormulaType
            {
                get { return _BaseFormulaType; }
                set { _BaseFormulaType = value; OnPropertyChanged("BaseFormulaType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _BaseFormulaType;
            
            /// <summary>
            /// Product or brand name of the enteral or infant formula
            /// </summary>
            [FhirElement("baseFormulaProductName", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString BaseFormulaProductNameElement
            {
                get { return _BaseFormulaProductNameElement; }
                set { _BaseFormulaProductNameElement = value; OnPropertyChanged("BaseFormulaProductNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _BaseFormulaProductNameElement;
            
            /// <summary>
            /// Product or brand name of the enteral or infant formula
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string BaseFormulaProductName
            {
                get { return BaseFormulaProductNameElement != null ? BaseFormulaProductNameElement.Value : null; }
                set
                {
                if (value == null)
                      BaseFormulaProductNameElement = null; 
                    else
                        BaseFormulaProductNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("BaseFormulaProductName");
                }
            }
            
            /// <summary>
            /// Type of modular component to add to the feeding
            /// </summary>
            [FhirElement("additiveType", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept AdditiveType
            {
                get { return _AdditiveType; }
                set { _AdditiveType = value; OnPropertyChanged("AdditiveType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _AdditiveType;
            
            /// <summary>
            /// Product or brand name of the modular additive
            /// </summary>
            [FhirElement("additiveProductName", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AdditiveProductNameElement
            {
                get { return _AdditiveProductNameElement; }
                set { _AdditiveProductNameElement = value; OnPropertyChanged("AdditiveProductNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AdditiveProductNameElement;
            
            /// <summary>
            /// Product or brand name of the modular additive
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string AdditiveProductName
            {
                get { return AdditiveProductNameElement != null ? AdditiveProductNameElement.Value : null; }
                set
                {
                if (value == null)
                      AdditiveProductNameElement = null; 
                    else
                        AdditiveProductNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("AdditiveProductName");
                }
            }
            
            /// <summary>
            /// Amount of energy per specified volume that is required
            /// </summary>
            [FhirElement("caloricDensity", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity CaloricDensity
            {
                get { return _CaloricDensity; }
                set { _CaloricDensity = value; OnPropertyChanged("CaloricDensity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _CaloricDensity;
            
            /// <summary>
            /// How the formula should enter the patient's gastrointestinal tract
            /// </summary>
            [FhirElement("routeofAdministration", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept RouteofAdministration
            {
                get { return _RouteofAdministration; }
                set { _RouteofAdministration = value; OnPropertyChanged("RouteofAdministration"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _RouteofAdministration;
            
            /// <summary>
            /// Formula feeding instruction as structured data
            /// </summary>
            [FhirElement("administration", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.NutritionRequest.AdministrationComponent> Administration
            {
                get { if(_Administration==null) _Administration = new List<Hl7.Fhir.Model.NutritionRequest.AdministrationComponent>(); return _Administration; }
                set { _Administration = value; OnPropertyChanged("Administration"); }
            }
            
            private List<Hl7.Fhir.Model.NutritionRequest.AdministrationComponent> _Administration;
            
            /// <summary>
            /// Upper limit on formula volume per unit of time
            /// </summary>
            [FhirElement("maxVolumeToDeliver", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity MaxVolumeToDeliver
            {
                get { return _MaxVolumeToDeliver; }
                set { _MaxVolumeToDeliver = value; OnPropertyChanged("MaxVolumeToDeliver"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _MaxVolumeToDeliver;
            
            /// <summary>
            /// Formula feeding instructions expressed as text
            /// </summary>
            [FhirElement("administrationInstruction", InSummary=true, Order=120)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AdministrationInstructionElement
            {
                get { return _AdministrationInstructionElement; }
                set { _AdministrationInstructionElement = value; OnPropertyChanged("AdministrationInstructionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AdministrationInstructionElement;
            
            /// <summary>
            /// Formula feeding instructions expressed as text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string AdministrationInstruction
            {
                get { return AdministrationInstructionElement != null ? AdministrationInstructionElement.Value : null; }
                set
                {
                if (value == null)
                      AdministrationInstructionElement = null; 
                    else
                        AdministrationInstructionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("AdministrationInstruction");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EnteralFormulaComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(BaseFormulaType != null) dest.BaseFormulaType = (Hl7.Fhir.Model.CodeableConcept)BaseFormulaType.DeepCopy();
                    if(BaseFormulaProductNameElement != null) dest.BaseFormulaProductNameElement = (Hl7.Fhir.Model.FhirString)BaseFormulaProductNameElement.DeepCopy();
                    if(AdditiveType != null) dest.AdditiveType = (Hl7.Fhir.Model.CodeableConcept)AdditiveType.DeepCopy();
                    if(AdditiveProductNameElement != null) dest.AdditiveProductNameElement = (Hl7.Fhir.Model.FhirString)AdditiveProductNameElement.DeepCopy();
                    if(CaloricDensity != null) dest.CaloricDensity = (Hl7.Fhir.Model.SimpleQuantity)CaloricDensity.DeepCopy();
                    if(RouteofAdministration != null) dest.RouteofAdministration = (Hl7.Fhir.Model.CodeableConcept)RouteofAdministration.DeepCopy();
                    if(Administration != null) dest.Administration = new List<Hl7.Fhir.Model.NutritionRequest.AdministrationComponent>(Administration.DeepCopy());
                    if(MaxVolumeToDeliver != null) dest.MaxVolumeToDeliver = (Hl7.Fhir.Model.SimpleQuantity)MaxVolumeToDeliver.DeepCopy();
                    if(AdministrationInstructionElement != null) dest.AdministrationInstructionElement = (Hl7.Fhir.Model.FhirString)AdministrationInstructionElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new EnteralFormulaComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EnteralFormulaComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(BaseFormulaType, otherT.BaseFormulaType)) return false;
                if( !DeepComparable.Matches(BaseFormulaProductNameElement, otherT.BaseFormulaProductNameElement)) return false;
                if( !DeepComparable.Matches(AdditiveType, otherT.AdditiveType)) return false;
                if( !DeepComparable.Matches(AdditiveProductNameElement, otherT.AdditiveProductNameElement)) return false;
                if( !DeepComparable.Matches(CaloricDensity, otherT.CaloricDensity)) return false;
                if( !DeepComparable.Matches(RouteofAdministration, otherT.RouteofAdministration)) return false;
                if( !DeepComparable.Matches(Administration, otherT.Administration)) return false;
                if( !DeepComparable.Matches(MaxVolumeToDeliver, otherT.MaxVolumeToDeliver)) return false;
                if( !DeepComparable.Matches(AdministrationInstructionElement, otherT.AdministrationInstructionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EnteralFormulaComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(BaseFormulaType, otherT.BaseFormulaType)) return false;
                if( !DeepComparable.IsExactly(BaseFormulaProductNameElement, otherT.BaseFormulaProductNameElement)) return false;
                if( !DeepComparable.IsExactly(AdditiveType, otherT.AdditiveType)) return false;
                if( !DeepComparable.IsExactly(AdditiveProductNameElement, otherT.AdditiveProductNameElement)) return false;
                if( !DeepComparable.IsExactly(CaloricDensity, otherT.CaloricDensity)) return false;
                if( !DeepComparable.IsExactly(RouteofAdministration, otherT.RouteofAdministration)) return false;
                if( !DeepComparable.IsExactly(Administration, otherT.Administration)) return false;
                if( !DeepComparable.IsExactly(MaxVolumeToDeliver, otherT.MaxVolumeToDeliver)) return false;
                if( !DeepComparable.IsExactly(AdministrationInstructionElement, otherT.AdministrationInstructionElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("AdministrationComponent")]
        [DataContract]
        public partial class AdministrationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AdministrationComponent"; } }
            
            /// <summary>
            /// Scheduled frequency of enteral feeding
            /// </summary>
            [FhirElement("schedule", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Timing Schedule
            {
                get { return _Schedule; }
                set { _Schedule = value; OnPropertyChanged("Schedule"); }
            }
            
            private Hl7.Fhir.Model.Timing _Schedule;
            
            /// <summary>
            /// The volume of formula to provide
            /// </summary>
            [FhirElement("quantity", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Speed with which the formula is provided per period of time
            /// </summary>
            [FhirElement("rate", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.SimpleQuantity),typeof(Hl7.Fhir.Model.Ratio))]
            [DataMember]
            public Hl7.Fhir.Model.Element Rate
            {
                get { return _Rate; }
                set { _Rate = value; OnPropertyChanged("Rate"); }
            }
            
            private Hl7.Fhir.Model.Element _Rate;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AdministrationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Schedule != null) dest.Schedule = (Hl7.Fhir.Model.Timing)Schedule.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.SimpleQuantity)Quantity.DeepCopy();
                    if(Rate != null) dest.Rate = (Hl7.Fhir.Model.Element)Rate.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new AdministrationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AdministrationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(Rate, otherT.Rate)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AdministrationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(Rate, otherT.Rate)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// Identifiers assigned to this order
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// proposed | draft | planned | requested | active | on-hold | completed | cancelled | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<Hl7.Fhir.Model.NutritionRequest.NutritionOrderStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.NutritionRequest.NutritionOrderStatus> _StatusElement;
        
        /// <summary>
        /// proposed | draft | planned | requested | active | on-hold | completed | cancelled | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.NutritionRequest.NutritionOrderStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.NutritionRequest.NutritionOrderStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// The person who requires the diet, formula or nutritional supplement
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=110)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// The encounter associated with this nutrition order
        /// </summary>
        [FhirElement("encounter", Order=120)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Date and time the nutrition order was requested
        /// </summary>
        [FhirElement("dateTime", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateTimeElement
        {
            get { return _DateTimeElement; }
            set { _DateTimeElement = value; OnPropertyChanged("DateTimeElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateTimeElement;
        
        /// <summary>
        /// Date and time the nutrition order was requested
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DateTime
        {
            get { return DateTimeElement != null ? DateTimeElement.Value : null; }
            set
            {
                if (value == null)
                  DateTimeElement = null; 
                else
                  DateTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("DateTime");
            }
        }
        
        /// <summary>
        /// Who ordered the diet, formula or nutritional supplement
        /// </summary>
        [FhirElement("orderer", InSummary=true, Order=140)]
        [References("Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Orderer
        {
            get { return _Orderer; }
            set { _Orderer = value; OnPropertyChanged("Orderer"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Orderer;
        
        /// <summary>
        /// List of the patient's food and nutrition-related allergies and intolerances
        /// </summary>
        [FhirElement("allergyIntolerance", Order=150)]
        [References("AllergyIntolerance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> AllergyIntolerance
        {
            get { if(_AllergyIntolerance==null) _AllergyIntolerance = new List<Hl7.Fhir.Model.ResourceReference>(); return _AllergyIntolerance; }
            set { _AllergyIntolerance = value; OnPropertyChanged("AllergyIntolerance"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _AllergyIntolerance;
        
        /// <summary>
        /// Order-specific modifier about the type of food that should be given
        /// </summary>
        [FhirElement("foodPreferenceModifier", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> FoodPreferenceModifier
        {
            get { if(_FoodPreferenceModifier==null) _FoodPreferenceModifier = new List<Hl7.Fhir.Model.CodeableConcept>(); return _FoodPreferenceModifier; }
            set { _FoodPreferenceModifier = value; OnPropertyChanged("FoodPreferenceModifier"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _FoodPreferenceModifier;
        
        /// <summary>
        /// Order-specific modifier about the type of food that should not be given
        /// </summary>
        [FhirElement("excludeFoodModifier", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ExcludeFoodModifier
        {
            get { if(_ExcludeFoodModifier==null) _ExcludeFoodModifier = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ExcludeFoodModifier; }
            set { _ExcludeFoodModifier = value; OnPropertyChanged("ExcludeFoodModifier"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _ExcludeFoodModifier;
        
        /// <summary>
        /// Oral diet components
        /// </summary>
        [FhirElement("oralDiet", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.NutritionRequest.OralDietComponent OralDiet
        {
            get { return _OralDiet; }
            set { _OralDiet = value; OnPropertyChanged("OralDiet"); }
        }
        
        private Hl7.Fhir.Model.NutritionRequest.OralDietComponent _OralDiet;
        
        /// <summary>
        /// Supplement components
        /// </summary>
        [FhirElement("supplement", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.NutritionRequest.SupplementComponent> Supplement
        {
            get { if(_Supplement==null) _Supplement = new List<Hl7.Fhir.Model.NutritionRequest.SupplementComponent>(); return _Supplement; }
            set { _Supplement = value; OnPropertyChanged("Supplement"); }
        }
        
        private List<Hl7.Fhir.Model.NutritionRequest.SupplementComponent> _Supplement;
        
        /// <summary>
        /// Enteral formula components
        /// </summary>
        [FhirElement("enteralFormula", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.NutritionRequest.EnteralFormulaComponent EnteralFormula
        {
            get { return _EnteralFormula; }
            set { _EnteralFormula = value; OnPropertyChanged("EnteralFormula"); }
        }
        
        private Hl7.Fhir.Model.NutritionRequest.EnteralFormulaComponent _EnteralFormula;
        

        public static ElementDefinition.ConstraintComponent NutritionRequest_NOR_1 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "oralDiet.exists() or supplement.exists() or enteralFormula.exists()",
            Key = "nor-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Nutrition Order SHALL contain either Oral Diet , Supplement, or Enteral Formula class",
            Xpath = "exists(f:oralDiet) or exists(f:supplement) or exists(f:enteralFormula)"
        };

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as NutritionRequest;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.NutritionRequest.NutritionOrderStatus>)StatusElement.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(DateTimeElement != null) dest.DateTimeElement = (Hl7.Fhir.Model.FhirDateTime)DateTimeElement.DeepCopy();
                if(Orderer != null) dest.Orderer = (Hl7.Fhir.Model.ResourceReference)Orderer.DeepCopy();
                if(AllergyIntolerance != null) dest.AllergyIntolerance = new List<Hl7.Fhir.Model.ResourceReference>(AllergyIntolerance.DeepCopy());
                if(FoodPreferenceModifier != null) dest.FoodPreferenceModifier = new List<Hl7.Fhir.Model.CodeableConcept>(FoodPreferenceModifier.DeepCopy());
                if(ExcludeFoodModifier != null) dest.ExcludeFoodModifier = new List<Hl7.Fhir.Model.CodeableConcept>(ExcludeFoodModifier.DeepCopy());
                if(OralDiet != null) dest.OralDiet = (Hl7.Fhir.Model.NutritionRequest.OralDietComponent)OralDiet.DeepCopy();
                if(Supplement != null) dest.Supplement = new List<Hl7.Fhir.Model.NutritionRequest.SupplementComponent>(Supplement.DeepCopy());
                if(EnteralFormula != null) dest.EnteralFormula = (Hl7.Fhir.Model.NutritionRequest.EnteralFormulaComponent)EnteralFormula.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new NutritionRequest());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as NutritionRequest;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(DateTimeElement, otherT.DateTimeElement)) return false;
            if( !DeepComparable.Matches(Orderer, otherT.Orderer)) return false;
            if( !DeepComparable.Matches(AllergyIntolerance, otherT.AllergyIntolerance)) return false;
            if( !DeepComparable.Matches(FoodPreferenceModifier, otherT.FoodPreferenceModifier)) return false;
            if( !DeepComparable.Matches(ExcludeFoodModifier, otherT.ExcludeFoodModifier)) return false;
            if( !DeepComparable.Matches(OralDiet, otherT.OralDiet)) return false;
            if( !DeepComparable.Matches(Supplement, otherT.Supplement)) return false;
            if( !DeepComparable.Matches(EnteralFormula, otherT.EnteralFormula)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as NutritionRequest;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(DateTimeElement, otherT.DateTimeElement)) return false;
            if( !DeepComparable.IsExactly(Orderer, otherT.Orderer)) return false;
            if( !DeepComparable.IsExactly(AllergyIntolerance, otherT.AllergyIntolerance)) return false;
            if( !DeepComparable.IsExactly(FoodPreferenceModifier, otherT.FoodPreferenceModifier)) return false;
            if( !DeepComparable.IsExactly(ExcludeFoodModifier, otherT.ExcludeFoodModifier)) return false;
            if( !DeepComparable.IsExactly(OralDiet, otherT.OralDiet)) return false;
            if( !DeepComparable.IsExactly(Supplement, otherT.Supplement)) return false;
            if( !DeepComparable.IsExactly(EnteralFormula, otherT.EnteralFormula)) return false;
            
            return true;
        }
        
    }
    
}