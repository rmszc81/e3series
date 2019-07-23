using System.Runtime.InteropServices;

using Autofac;
using e3;

namespace e3PluginDemo.Modules.Interop
{
    public class ModuleCom : Module
    {
        protected override void Load(ContainerBuilder ContainerBuilder)
        {
            // e3 injection //
            ContainerBuilder.RegisterType<e3ApplicationClass>().As<IApplicationInterface>().OnRelease(e3Application => Marshal.FinalReleaseComObject(e3Application));
            ContainerBuilder.RegisterType<e3AttributeClass>().As<IAttributeInterface>().OnRelease(e3Attribute => Marshal.FinalReleaseComObject(e3Attribute));
            ContainerBuilder.RegisterType<e3AttributeDefinitionClass>().As<IAttributeDefinitionInterface>().OnRelease(e3AttributeDefinition => Marshal.FinalReleaseComObject(e3AttributeDefinition));
            ContainerBuilder.RegisterType<e3BinDataClass>().As<IBinDataInterface>().OnRelease(e3BinData => Marshal.FinalReleaseComObject(e3BinData));
            ContainerBuilder.RegisterType<e3BoardClass>().As<IBoardInterface>().OnRelease(e3Board => Marshal.FinalReleaseComObject(e3Board));
            ContainerBuilder.RegisterType<e3BundleClass>().As<IBundleInterface>().OnRelease(e3Bundle => Marshal.FinalReleaseComObject(e3Bundle));
            ContainerBuilder.RegisterType<e3CavityPartClass>().As<ICavityPartInterface>().OnRelease(e3CavityPart => Marshal.FinalReleaseComObject(e3CavityPart));
            ContainerBuilder.RegisterType<e3ClipboardClass>().As<IClipboardInterface>().OnRelease(e3Clipboard => Marshal.FinalReleaseComObject(e3Clipboard));
            ContainerBuilder.RegisterType<e3ComponentClass>().As<IComponentInterface>().OnRelease(e3Component => Marshal.FinalReleaseComObject(e3Component));
            ContainerBuilder.RegisterType<e3ConnectionClass>().As<IConnectionInterface>().OnRelease(e3Connection => Marshal.FinalReleaseComObject(e3Connection));
            ContainerBuilder.RegisterType<e3ConnectLineClass>().As<IConnectLineInterface>().OnRelease(e3ConnectLine => Marshal.FinalReleaseComObject(e3ConnectLine));
            ContainerBuilder.RegisterType<e3DeviceClass>().As<IDeviceInterface>().OnRelease(e3Device => Marshal.FinalReleaseComObject(e3Device));
            ContainerBuilder.RegisterType<e3DimensionClass>().As<IDimensionInterface>().OnRelease(e3Dimension => Marshal.FinalReleaseComObject(e3Dimension));
            ContainerBuilder.RegisterType<e3DllInterfaceClass>().As<IDllInterface>().OnRelease(e3DllInterface => Marshal.FinalReleaseComObject(e3DllInterface));
            ContainerBuilder.RegisterType<e3ExternalDocumentClass>().As<IExternalDocumentInterface>().OnRelease(e3ExternalDocument => Marshal.FinalReleaseComObject(e3ExternalDocument));
            ContainerBuilder.RegisterType<e3FieldClass>().As<IFieldInterface>().OnRelease(e3Field => Marshal.FinalReleaseComObject(e3Field));
            ContainerBuilder.RegisterType<e3FunctionalPortClass>().As<IFunctionalPortInterface>().OnRelease(e3FunctionalPort => Marshal.FinalReleaseComObject(e3FunctionalPort));
            ContainerBuilder.RegisterType<e3FunctionalUnitClass>().As<IFunctionalUnitInterface>().OnRelease(e3FunctionalUnit => Marshal.FinalReleaseComObject(e3FunctionalUnit));
            ContainerBuilder.RegisterType<e3GraphClass>().As<IGraphInterface>().OnRelease(e3Graph => Marshal.FinalReleaseComObject(e3Graph));
            ContainerBuilder.RegisterType<e3GroupClass>().As<IGroupInterface>().OnRelease(e3Group => Marshal.FinalReleaseComObject(e3Group));
            ContainerBuilder.RegisterType<e3InfoApplicationClass>().As<IInfoApplicationInterface>().OnRelease(e3InfoApplication => Marshal.FinalReleaseComObject(e3InfoApplication));
            ContainerBuilder.RegisterType<e3JobClass>().As<IJobInterface>().OnRelease(e3Job => Marshal.FinalReleaseComObject(e3Job));
            ContainerBuilder.RegisterType<e3LayerClass>().As<ILayerInterface>().OnRelease(e3Layer => Marshal.FinalReleaseComObject(e3Layer));
            ContainerBuilder.RegisterType<e3ModuleClass>().As<IModuleInterface>().OnRelease(e3Module => Marshal.FinalReleaseComObject(e3Module));
            ContainerBuilder.RegisterType<e3ModulePortClass>().As<IModulePortInterface>().OnRelease(e3ModulePort => Marshal.FinalReleaseComObject(e3ModulePort));
            ContainerBuilder.RegisterType<e3NetClass>().As<INetInterface>().OnRelease(e3Net => Marshal.FinalReleaseComObject(e3Net));
            ContainerBuilder.RegisterType<e3NetSegmentClass>().As<INetSegmentInterface>().OnRelease(e3NetSegment => Marshal.FinalReleaseComObject(e3NetSegment));
            ContainerBuilder.RegisterType<e3OptionClass>().As<IOptionInterface>().OnRelease(e3Option => Marshal.FinalReleaseComObject(e3Option));
            ContainerBuilder.RegisterType<e3OutlineClass>().As<IOutlineInterface>().OnRelease(e3Outline => Marshal.FinalReleaseComObject(e3Outline));
            ContainerBuilder.RegisterType<e3PinClass>().As<IPinInterface>().OnRelease(e3Pin => Marshal.FinalReleaseComObject(e3Pin));
            ContainerBuilder.RegisterType<e3SheetClass>().As<ISheetInterface>().OnRelease(e3Sheet => Marshal.FinalReleaseComObject(e3Sheet));
            ContainerBuilder.RegisterType<e3SignalClass_2>().As<ISignalInterface>().OnRelease(e3SignalClass => Marshal.FinalReleaseComObject(e3SignalClass));
            ContainerBuilder.RegisterType<e3SignalClassClass>().As<ISignalClassInterface>().OnRelease(e3SignalClass => Marshal.FinalReleaseComObject(e3SignalClass));
            ContainerBuilder.RegisterType<e3SlotClass>().As<ISlotInterface>().OnRelease(e3Slot => Marshal.FinalReleaseComObject(e3Slot));
            ContainerBuilder.RegisterType<e3StructureNodeClass>().As<IStructureNodeInterface>().OnRelease(e3StructureNode => Marshal.FinalReleaseComObject(e3StructureNode));
            ContainerBuilder.RegisterType<e3SupplyClass>().As<ISupplyInterface>().OnRelease(e3Supply => Marshal.FinalReleaseComObject(e3Supply));
            ContainerBuilder.RegisterType<e3SymbolClass>().As<ISymbolInterface>().OnRelease(e3Symbol => Marshal.FinalReleaseComObject(e3Symbol));
            ContainerBuilder.RegisterType<e3TestpointClass>().As<ITestpointInterface>().OnRelease(e3Testpoint => Marshal.FinalReleaseComObject(e3Testpoint));
            ContainerBuilder.RegisterType<e3TextClass>().As<ITextInterface>().OnRelease(e3Text => Marshal.FinalReleaseComObject(e3Text));
            ContainerBuilder.RegisterType<e3TreeClass>().As<ITreeInterface>().OnRelease(e3Tree => Marshal.FinalReleaseComObject(e3Tree));
            ContainerBuilder.RegisterType<e3UserMenuItemClass>().As<IUserMenuItemInterface>().OnRelease(e3UserMenuItem => Marshal.FinalReleaseComObject(e3UserMenuItem));
            ContainerBuilder.RegisterType<e3VariantClass>().As<IVariantInterface>().OnRelease(e3Variant => Marshal.FinalReleaseComObject(e3Variant));
            ContainerBuilder.RegisterType<e3WespeClass>().As<IWespeInterface>().OnRelease(e3Wespe => Marshal.FinalReleaseComObject(e3Wespe));

            // database editor injection //
            ContainerBuilder.RegisterType<e3DbeApplicationClass>().As<IDbeApplicationInterface>().OnRelease(e3DbeApplication => Marshal.FinalReleaseComObject(e3DbeApplication));
            ContainerBuilder.RegisterType<e3DbeAttributeClass>().As<IDbeAttributeInterface>().OnRelease(e3DbeAttribute => Marshal.FinalReleaseComObject(e3DbeAttribute));
            ContainerBuilder.RegisterType<e3DbeBridgeClass>().As<IDbeBridge>().OnRelease(e3DbeBridge => Marshal.FinalReleaseComObject(e3DbeBridge));
            ContainerBuilder.RegisterType<e3DbeComponentClass>().As<IDbeComponentInterface>().OnRelease(e3DbeComponent => Marshal.FinalReleaseComObject(e3DbeComponent));
            ContainerBuilder.RegisterType<e3DbeGraphClass>().As<IDbeGraphInterface>().OnRelease(e3DbeGraph => Marshal.FinalReleaseComObject(e3DbeGraph));
            ContainerBuilder.RegisterType<e3DbeModelClass>().As<IDbeModelInterface>().OnRelease(e3DbeModel => Marshal.FinalReleaseComObject(e3DbeModel));
            ContainerBuilder.RegisterType<e3DbeSymbolClass>().As<IDbeSymbolInterface>().OnRelease(e3DbeSymbol => Marshal.FinalReleaseComObject(e3DbeSymbol));
            ContainerBuilder.RegisterType<e3DbeTextClass>().As<IDbeTextInterface>().OnRelease(e3DbeText => Marshal.FinalReleaseComObject(e3DbeText));
        }
    }
}
