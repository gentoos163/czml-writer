// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Model</c> to a <see cref="CesiumOutputStream" />.  A <c>Model</c> is a 3D model.
    /// </summary>
    public class ModelCesiumWriter : CesiumPropertyWriter<ModelCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>show</c> property.
        /// </summary>
        public const string ShowPropertyName = "show";

        /// <summary>
        /// The name of the <c>gltf</c> property.
        /// </summary>
        public const string GltfPropertyName = "gltf";

        /// <summary>
        /// The name of the <c>scale</c> property.
        /// </summary>
        public const string ScalePropertyName = "scale";

        /// <summary>
        /// The name of the <c>minimumPixelSize</c> property.
        /// </summary>
        public const string MinimumPixelSizePropertyName = "minimumPixelSize";

        /// <summary>
        /// The name of the <c>maximumScale</c> property.
        /// </summary>
        public const string MaximumScalePropertyName = "maximumScale";

        /// <summary>
        /// The name of the <c>incrementallyLoadTextures</c> property.
        /// </summary>
        public const string IncrementallyLoadTexturesPropertyName = "incrementallyLoadTextures";

        /// <summary>
        /// The name of the <c>runAnimations</c> property.
        /// </summary>
        public const string RunAnimationsPropertyName = "runAnimations";

        /// <summary>
        /// The name of the <c>shadows</c> property.
        /// </summary>
        public const string ShadowsPropertyName = "shadows";

        /// <summary>
        /// The name of the <c>heightReference</c> property.
        /// </summary>
        public const string HeightReferencePropertyName = "heightReference";

        /// <summary>
        /// The name of the <c>silhouetteColor</c> property.
        /// </summary>
        public const string SilhouetteColorPropertyName = "silhouetteColor";

        /// <summary>
        /// The name of the <c>silhouetteSize</c> property.
        /// </summary>
        public const string SilhouetteSizePropertyName = "silhouetteSize";

        /// <summary>
        /// The name of the <c>color</c> property.
        /// </summary>
        public const string ColorPropertyName = "color";

        /// <summary>
        /// The name of the <c>colorBlendMode</c> property.
        /// </summary>
        public const string ColorBlendModePropertyName = "colorBlendMode";

        /// <summary>
        /// The name of the <c>colorBlendAmount</c> property.
        /// </summary>
        public const string ColorBlendAmountPropertyName = "colorBlendAmount";

        /// <summary>
        /// The name of the <c>nodeTransformations</c> property.
        /// </summary>
        public const string NodeTransformationsPropertyName = "nodeTransformations";

        private readonly Lazy<BooleanCesiumWriter> m_show = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowPropertyName), false);
        private readonly Lazy<UriCesiumWriter> m_gltf = new Lazy<UriCesiumWriter>(() => new UriCesiumWriter(GltfPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_scale = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(ScalePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_minimumPixelSize = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(MinimumPixelSizePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_maximumScale = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(MaximumScalePropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_incrementallyLoadTextures = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(IncrementallyLoadTexturesPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_runAnimations = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(RunAnimationsPropertyName), false);
        private readonly Lazy<ShadowModeCesiumWriter> m_shadows = new Lazy<ShadowModeCesiumWriter>(() => new ShadowModeCesiumWriter(ShadowsPropertyName), false);
        private readonly Lazy<HeightReferenceCesiumWriter> m_heightReference = new Lazy<HeightReferenceCesiumWriter>(() => new HeightReferenceCesiumWriter(HeightReferencePropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_silhouetteColor = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(SilhouetteColorPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_silhouetteSize = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(SilhouetteSizePropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_color = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(ColorPropertyName), false);
        private readonly Lazy<ColorBlendModeCesiumWriter> m_colorBlendMode = new Lazy<ColorBlendModeCesiumWriter>(() => new ColorBlendModeCesiumWriter(ColorBlendModePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_colorBlendAmount = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(ColorBlendAmountPropertyName), false);
        private readonly Lazy<NodeTransformationsCesiumWriter> m_nodeTransformations = new Lazy<NodeTransformationsCesiumWriter>(() => new NodeTransformationsCesiumWriter(NodeTransformationsPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public ModelCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected ModelCesiumWriter(ModelCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override ModelCesiumWriter Clone()
        {
            return new ModelCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>show</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>show</c> property defines whether or not the model is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter ShowWriter
        {
            get { return m_show.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>show</c> property.  The <c>show</c> property defines whether or not the model is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenShowProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowWriter);
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>boolean</c> value.  The <c>show</c> property specifies whether or not the model is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowProperty(bool value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the model is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowPropertyReference(Reference value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the model is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowPropertyReference(string value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the model is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the model is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>gltf</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>gltf</c> property defines the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        public UriCesiumWriter GltfWriter
        {
            get { return m_gltf.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>gltf</c> property.  The <c>gltf</c> property defines the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        public UriCesiumWriter OpenGltfProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(GltfWriter);
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>uri</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="resource">A resource object describing external data.</param>
        public void WriteGltfProperty(CesiumResource resource)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteUri(resource);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>uri</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="uri">The URI of the data.</param>
        /// <param name="resourceBehavior">An enumeration describing how to include the URI in the document. For even more control, use the overload that takes a ICesiumUriResolver.</param>
        public void WriteGltfProperty(Uri uri, CesiumResourceBehavior resourceBehavior)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteUri(uri, resourceBehavior);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>uri</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="uri">The URI of the data.</param>
        /// <param name="resourceBehavior">An enumeration describing how to include the URI in the document. For even more control, use the overload that takes a ICesiumUriResolver.</param>
        public void WriteGltfProperty(string uri, CesiumResourceBehavior resourceBehavior)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteUri(uri, resourceBehavior);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>uri</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="uri">The URI of the data.  The provided ICesiumUriResolver will be used to build the final URI embedded in the document.</param>
        /// <param name="resolver">An ICesiumUriResolver used to build the final URI that will be embedded in the document.</param>
        public void WriteGltfProperty(Uri uri, ICesiumUriResolver resolver)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteUri(uri, resolver);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>uri</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="uri">The URI of the data.  The provided ICesiumUriResolver will be used to build the final URI embedded in the document.</param>
        /// <param name="resolver">An ICesiumUriResolver used to build the final URI that will be embedded in the document.</param>
        public void WriteGltfProperty(string uri, ICesiumUriResolver resolver)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteUri(uri, resolver);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>uri</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="image">The image.  A data URI will be created for this image, using PNG encoding.</param>
        public void WriteGltfProperty(Image image)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteUri(image);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>uri</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="image">The image.  A data URI will be created for this image.</param>
        /// <param name="imageFormat">The image format to use to encode the image in the data URI.</param>
        public void WriteGltfProperty(Image image, CesiumImageFormat imageFormat)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteUri(image, imageFormat);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>reference</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteGltfPropertyReference(Reference value)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>reference</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteGltfPropertyReference(string value)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>reference</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteGltfPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>gltf</c> property as a <c>reference</c> value.  The <c>gltf</c> property specifies the URI of a <a href="https://github.com/KhronosGroup/glTF">glTF</a> model.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteGltfPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenGltfProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>scale</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>scale</c> property defines the scale of the model.
        /// </summary>
        public DoubleCesiumWriter ScaleWriter
        {
            get { return m_scale.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>scale</c> property.  The <c>scale</c> property defines the scale of the model.
        /// </summary>
        public DoubleCesiumWriter OpenScaleProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ScaleWriter);
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>number</c> value.  The <c>scale</c> property specifies the scale of the model.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteScaleProperty(double value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>number</c> value.  The <c>scale</c> property specifies the scale of the model.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteScaleProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>number</c> value.  The <c>scale</c> property specifies the scale of the model.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteScaleProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scale of the model.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteScalePropertyReference(Reference value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scale of the model.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteScalePropertyReference(string value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scale of the model.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteScalePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scale of the model.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteScalePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>minimumPixelSize</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>minimumPixelSize</c> property defines the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        public DoubleCesiumWriter MinimumPixelSizeWriter
        {
            get { return m_minimumPixelSize.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>minimumPixelSize</c> property.  The <c>minimumPixelSize</c> property defines the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        public DoubleCesiumWriter OpenMinimumPixelSizeProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MinimumPixelSizeWriter);
        }

        /// <summary>
        /// Writes a value for the <c>minimumPixelSize</c> property as a <c>number</c> value.  The <c>minimumPixelSize</c> property specifies the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteMinimumPixelSizeProperty(double value)
        {
            using (var writer = OpenMinimumPixelSizeProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumPixelSize</c> property as a <c>number</c> value.  The <c>minimumPixelSize</c> property specifies the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteMinimumPixelSizeProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenMinimumPixelSizeProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumPixelSize</c> property as a <c>number</c> value.  The <c>minimumPixelSize</c> property specifies the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteMinimumPixelSizeProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenMinimumPixelSizeProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumPixelSize</c> property as a <c>reference</c> value.  The <c>minimumPixelSize</c> property specifies the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteMinimumPixelSizePropertyReference(Reference value)
        {
            using (var writer = OpenMinimumPixelSizeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumPixelSize</c> property as a <c>reference</c> value.  The <c>minimumPixelSize</c> property specifies the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteMinimumPixelSizePropertyReference(string value)
        {
            using (var writer = OpenMinimumPixelSizeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumPixelSize</c> property as a <c>reference</c> value.  The <c>minimumPixelSize</c> property specifies the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteMinimumPixelSizePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenMinimumPixelSizeProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>minimumPixelSize</c> property as a <c>reference</c> value.  The <c>minimumPixelSize</c> property specifies the approximate minimum pixel size of the model regardless of zoom.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteMinimumPixelSizePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenMinimumPixelSizeProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>maximumScale</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>maximumScale</c> property defines the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        public DoubleCesiumWriter MaximumScaleWriter
        {
            get { return m_maximumScale.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>maximumScale</c> property.  The <c>maximumScale</c> property defines the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        public DoubleCesiumWriter OpenMaximumScaleProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MaximumScaleWriter);
        }

        /// <summary>
        /// Writes a value for the <c>maximumScale</c> property as a <c>number</c> value.  The <c>maximumScale</c> property specifies the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteMaximumScaleProperty(double value)
        {
            using (var writer = OpenMaximumScaleProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumScale</c> property as a <c>number</c> value.  The <c>maximumScale</c> property specifies the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteMaximumScaleProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenMaximumScaleProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumScale</c> property as a <c>number</c> value.  The <c>maximumScale</c> property specifies the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteMaximumScaleProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenMaximumScaleProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumScale</c> property as a <c>reference</c> value.  The <c>maximumScale</c> property specifies the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteMaximumScalePropertyReference(Reference value)
        {
            using (var writer = OpenMaximumScaleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumScale</c> property as a <c>reference</c> value.  The <c>maximumScale</c> property specifies the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteMaximumScalePropertyReference(string value)
        {
            using (var writer = OpenMaximumScaleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumScale</c> property as a <c>reference</c> value.  The <c>maximumScale</c> property specifies the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteMaximumScalePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenMaximumScaleProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>maximumScale</c> property as a <c>reference</c> value.  The <c>maximumScale</c> property specifies the maximum scale size of the model. This is used as an upper limit for <c>minimumPixelSize</c>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteMaximumScalePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenMaximumScaleProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>incrementallyLoadTextures</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>incrementallyLoadTextures</c> property defines whether or not the model can be rendered before all textures have loaded.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter IncrementallyLoadTexturesWriter
        {
            get { return m_incrementallyLoadTextures.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>incrementallyLoadTextures</c> property.  The <c>incrementallyLoadTextures</c> property defines whether or not the model can be rendered before all textures have loaded.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenIncrementallyLoadTexturesProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(IncrementallyLoadTexturesWriter);
        }

        /// <summary>
        /// Writes a value for the <c>incrementallyLoadTextures</c> property as a <c>boolean</c> value.  The <c>incrementallyLoadTextures</c> property specifies whether or not the model can be rendered before all textures have loaded.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteIncrementallyLoadTexturesProperty(bool value)
        {
            using (var writer = OpenIncrementallyLoadTexturesProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>incrementallyLoadTextures</c> property as a <c>reference</c> value.  The <c>incrementallyLoadTextures</c> property specifies whether or not the model can be rendered before all textures have loaded.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteIncrementallyLoadTexturesPropertyReference(Reference value)
        {
            using (var writer = OpenIncrementallyLoadTexturesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>incrementallyLoadTextures</c> property as a <c>reference</c> value.  The <c>incrementallyLoadTextures</c> property specifies whether or not the model can be rendered before all textures have loaded.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteIncrementallyLoadTexturesPropertyReference(string value)
        {
            using (var writer = OpenIncrementallyLoadTexturesProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>incrementallyLoadTextures</c> property as a <c>reference</c> value.  The <c>incrementallyLoadTextures</c> property specifies whether or not the model can be rendered before all textures have loaded.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteIncrementallyLoadTexturesPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenIncrementallyLoadTexturesProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>incrementallyLoadTextures</c> property as a <c>reference</c> value.  The <c>incrementallyLoadTextures</c> property specifies whether or not the model can be rendered before all textures have loaded.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteIncrementallyLoadTexturesPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenIncrementallyLoadTexturesProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>runAnimations</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>runAnimations</c> property defines whether or not to run all animations defined in the glTF model.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter RunAnimationsWriter
        {
            get { return m_runAnimations.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>runAnimations</c> property.  The <c>runAnimations</c> property defines whether or not to run all animations defined in the glTF model.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenRunAnimationsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RunAnimationsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>runAnimations</c> property as a <c>boolean</c> value.  The <c>runAnimations</c> property specifies whether or not to run all animations defined in the glTF model.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRunAnimationsProperty(bool value)
        {
            using (var writer = OpenRunAnimationsProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>runAnimations</c> property as a <c>reference</c> value.  The <c>runAnimations</c> property specifies whether or not to run all animations defined in the glTF model.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRunAnimationsPropertyReference(Reference value)
        {
            using (var writer = OpenRunAnimationsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>runAnimations</c> property as a <c>reference</c> value.  The <c>runAnimations</c> property specifies whether or not to run all animations defined in the glTF model.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteRunAnimationsPropertyReference(string value)
        {
            using (var writer = OpenRunAnimationsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>runAnimations</c> property as a <c>reference</c> value.  The <c>runAnimations</c> property specifies whether or not to run all animations defined in the glTF model.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteRunAnimationsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenRunAnimationsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>runAnimations</c> property as a <c>reference</c> value.  The <c>runAnimations</c> property specifies whether or not to run all animations defined in the glTF model.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteRunAnimationsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenRunAnimationsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>shadows</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>shadows</c> property defines whether or not the model casts or receives shadows.  If not specified, the default value is ENABLED.
        /// </summary>
        public ShadowModeCesiumWriter ShadowsWriter
        {
            get { return m_shadows.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>shadows</c> property.  The <c>shadows</c> property defines whether or not the model casts or receives shadows.  If not specified, the default value is ENABLED.
        /// </summary>
        public ShadowModeCesiumWriter OpenShadowsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShadowsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>shadowMode</c> value.  The <c>shadows</c> property specifies whether or not the model casts or receives shadows.  If not specified, the default value is ENABLED.
        /// </summary>
        /// <param name="value">The shadow mode.</param>
        public void WriteShadowsProperty(CesiumShadowMode value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteShadowMode(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the model casts or receives shadows.  If not specified, the default value is ENABLED.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShadowsPropertyReference(Reference value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the model casts or receives shadows.  If not specified, the default value is ENABLED.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShadowsPropertyReference(string value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the model casts or receives shadows.  If not specified, the default value is ENABLED.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShadowsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the model casts or receives shadows.  If not specified, the default value is ENABLED.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShadowsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>heightReference</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>heightReference</c> property defines the height reference of the model, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        public HeightReferenceCesiumWriter HeightReferenceWriter
        {
            get { return m_heightReference.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>heightReference</c> property.  The <c>heightReference</c> property defines the height reference of the model, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        public HeightReferenceCesiumWriter OpenHeightReferenceProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(HeightReferenceWriter);
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>heightReference</c> value.  The <c>heightReference</c> property specifies the height reference of the model, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="value">The height reference.</param>
        public void WriteHeightReferenceProperty(CesiumHeightReference value)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteHeightReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>reference</c> value.  The <c>heightReference</c> property specifies the height reference of the model, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteHeightReferencePropertyReference(Reference value)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>reference</c> value.  The <c>heightReference</c> property specifies the height reference of the model, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteHeightReferencePropertyReference(string value)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>reference</c> value.  The <c>heightReference</c> property specifies the height reference of the model, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteHeightReferencePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>reference</c> value.  The <c>heightReference</c> property specifies the height reference of the model, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteHeightReferencePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>silhouetteColor</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>silhouetteColor</c> property defines the color of the silhouette drawn around the model.
        /// </summary>
        public ColorCesiumWriter SilhouetteColorWriter
        {
            get { return m_silhouetteColor.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>silhouetteColor</c> property.  The <c>silhouetteColor</c> property defines the color of the silhouette drawn around the model.
        /// </summary>
        public ColorCesiumWriter OpenSilhouetteColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(SilhouetteColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>rgba</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteSilhouetteColorProperty(Color color)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>rgba</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteSilhouetteColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>rgba</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteSilhouetteColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>rgba</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteSilhouetteColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>rgbaf</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteSilhouetteColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>rgbaf</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteSilhouetteColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>rgbaf</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteSilhouetteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>rgbaf</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteSilhouetteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>reference</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteSilhouetteColorPropertyReference(Reference value)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>reference</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteSilhouetteColorPropertyReference(string value)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>reference</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteSilhouetteColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteColor</c> property as a <c>reference</c> value.  The <c>silhouetteColor</c> property specifies the color of the silhouette drawn around the model.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteSilhouetteColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenSilhouetteColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>silhouetteSize</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>silhouetteSize</c> property defines the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        public DoubleCesiumWriter SilhouetteSizeWriter
        {
            get { return m_silhouetteSize.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>silhouetteSize</c> property.  The <c>silhouetteSize</c> property defines the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        public DoubleCesiumWriter OpenSilhouetteSizeProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(SilhouetteSizeWriter);
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteSize</c> property as a <c>number</c> value.  The <c>silhouetteSize</c> property specifies the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteSilhouetteSizeProperty(double value)
        {
            using (var writer = OpenSilhouetteSizeProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteSize</c> property as a <c>number</c> value.  The <c>silhouetteSize</c> property specifies the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteSilhouetteSizeProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenSilhouetteSizeProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteSize</c> property as a <c>number</c> value.  The <c>silhouetteSize</c> property specifies the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteSilhouetteSizeProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenSilhouetteSizeProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteSize</c> property as a <c>reference</c> value.  The <c>silhouetteSize</c> property specifies the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteSilhouetteSizePropertyReference(Reference value)
        {
            using (var writer = OpenSilhouetteSizeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteSize</c> property as a <c>reference</c> value.  The <c>silhouetteSize</c> property specifies the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteSilhouetteSizePropertyReference(string value)
        {
            using (var writer = OpenSilhouetteSizeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteSize</c> property as a <c>reference</c> value.  The <c>silhouetteSize</c> property specifies the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteSilhouetteSizePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenSilhouetteSizeProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>silhouetteSize</c> property as a <c>reference</c> value.  The <c>silhouetteSize</c> property specifies the size, in pixels, of the silhouette drawn around the model.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteSilhouetteSizePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenSilhouetteSizeProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>color</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>color</c> property defines the color to blend with the model's rendered color.
        /// </summary>
        public ColorCesiumWriter ColorWriter
        {
            get { return m_color.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>color</c> property.  The <c>color</c> property defines the color to blend with the model's rendered color.
        /// </summary>
        public ColorCesiumWriter OpenColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorProperty(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorPropertyReference(Reference value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteColorPropertyReference(string value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color to blend with the model's rendered color.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>colorBlendMode</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>colorBlendMode</c> property defines the mode to use for blending between <c>color</c> and the model's color.  If not specified, the default value is HIGHLIGHT.
        /// </summary>
        public ColorBlendModeCesiumWriter ColorBlendModeWriter
        {
            get { return m_colorBlendMode.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>colorBlendMode</c> property.  The <c>colorBlendMode</c> property defines the mode to use for blending between <c>color</c> and the model's color.  If not specified, the default value is HIGHLIGHT.
        /// </summary>
        public ColorBlendModeCesiumWriter OpenColorBlendModeProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorBlendModeWriter);
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendMode</c> property as a <c>colorBlendMode</c> value.  The <c>colorBlendMode</c> property specifies the mode to use for blending between <c>color</c> and the model's color.  If not specified, the default value is HIGHLIGHT.
        /// </summary>
        /// <param name="value">The blend mode.</param>
        public void WriteColorBlendModeProperty(CesiumColorBlendMode value)
        {
            using (var writer = OpenColorBlendModeProperty())
            {
                writer.WriteColorBlendMode(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendMode</c> property as a <c>reference</c> value.  The <c>colorBlendMode</c> property specifies the mode to use for blending between <c>color</c> and the model's color.  If not specified, the default value is HIGHLIGHT.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorBlendModePropertyReference(Reference value)
        {
            using (var writer = OpenColorBlendModeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendMode</c> property as a <c>reference</c> value.  The <c>colorBlendMode</c> property specifies the mode to use for blending between <c>color</c> and the model's color.  If not specified, the default value is HIGHLIGHT.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteColorBlendModePropertyReference(string value)
        {
            using (var writer = OpenColorBlendModeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendMode</c> property as a <c>reference</c> value.  The <c>colorBlendMode</c> property specifies the mode to use for blending between <c>color</c> and the model's color.  If not specified, the default value is HIGHLIGHT.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorBlendModePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorBlendModeProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendMode</c> property as a <c>reference</c> value.  The <c>colorBlendMode</c> property specifies the mode to use for blending between <c>color</c> and the model's color.  If not specified, the default value is HIGHLIGHT.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorBlendModePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorBlendModeProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>colorBlendAmount</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>colorBlendAmount</c> property defines the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        public DoubleCesiumWriter ColorBlendAmountWriter
        {
            get { return m_colorBlendAmount.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>colorBlendAmount</c> property.  The <c>colorBlendAmount</c> property defines the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        public DoubleCesiumWriter OpenColorBlendAmountProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorBlendAmountWriter);
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendAmount</c> property as a <c>number</c> value.  The <c>colorBlendAmount</c> property specifies the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteColorBlendAmountProperty(double value)
        {
            using (var writer = OpenColorBlendAmountProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendAmount</c> property as a <c>number</c> value.  The <c>colorBlendAmount</c> property specifies the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorBlendAmountProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenColorBlendAmountProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendAmount</c> property as a <c>number</c> value.  The <c>colorBlendAmount</c> property specifies the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorBlendAmountProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenColorBlendAmountProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendAmount</c> property as a <c>reference</c> value.  The <c>colorBlendAmount</c> property specifies the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorBlendAmountPropertyReference(Reference value)
        {
            using (var writer = OpenColorBlendAmountProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendAmount</c> property as a <c>reference</c> value.  The <c>colorBlendAmount</c> property specifies the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteColorBlendAmountPropertyReference(string value)
        {
            using (var writer = OpenColorBlendAmountProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendAmount</c> property as a <c>reference</c> value.  The <c>colorBlendAmount</c> property specifies the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorBlendAmountPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorBlendAmountProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>colorBlendAmount</c> property as a <c>reference</c> value.  The <c>colorBlendAmount</c> property specifies the color strength when <c>colorBlendMode</c> is <c>MIX</c>. A value of 0.0 results in the model's rendered color while a value of 1.0 results in a solid color, with any value in-between resulting in a mix of the two.  If not specified, the default value is 0.5.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorBlendAmountPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorBlendAmountProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>nodeTransformations</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>nodeTransformations</c> property defines a mapping of node names to node transformations.
        /// </summary>
        public NodeTransformationsCesiumWriter NodeTransformationsWriter
        {
            get { return m_nodeTransformations.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>nodeTransformations</c> property.  The <c>nodeTransformations</c> property defines a mapping of node names to node transformations.
        /// </summary>
        public NodeTransformationsCesiumWriter OpenNodeTransformationsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(NodeTransformationsWriter);
        }

    }
}
