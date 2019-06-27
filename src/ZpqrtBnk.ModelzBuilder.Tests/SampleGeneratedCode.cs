﻿//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    ZpqrtBnk.ModelzBuilder alpha
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using ZpqrtBnk.ModelzBuilder.Umbraco;
using Umbraco.Web;

namespace ZpqrtBnk.ModelzBuilder.Tests.Models
{
    // Content Type with alias "page"
    public partial class Page : PublishedContentModel
    {
        public Page(IPublishedContent content)
            : base(content)
        { }

        public string UmbracoUrlName
        {
            get { return this.Value<string>("umbracoUrlName"); }
        }

        public int UmbracoInternalRedirectId
        {
            get { return this.Value<int>("umbracoInternalRedirectId"); }
        }

        public int UmbracoRedirect
        {
            get { return this.Value<int>("umbracoRedirect"); }
        }

        public string PageKey
        {
            get { return this.Value<string>("pageKey"); }
        }

        public object Mntp1
        {
            get { return this.Value("mntp1"); }
        }

        public object Mntp2
        {
            get { return this.Value("mntp2"); }
        }
    }

    // Content Type with alias "AnotherPage"
    public partial class AnotherPage : PublishedContentModel
    {
        public AnotherPage(IPublishedContent content)
            : base(content)
        { }

        public string UmbracoUrlAlias
        {
            get { return this.Value<string>("umbracoUrlAlias"); }
        }

        public string Nothing
        {
            get { return this.Value<string>("nothing"); }
        }
    }

    // Content Type with alias "loskDalmosk"
    public partial class LoskDalmosk : PublishedContentModel
    {
        public LoskDalmosk(IPublishedContent content)
            : base(content)
        { }
    }

    // Content Type with alias "parentDoc"
    public partial class ParentDoc : PublishedContentModel
    {
        public ParentDoc(IPublishedContent content)
            : base(content)
        { }

        public string Prop1
        {
            get { return this.Value<string>("prop1"); }
        }
    }

    // Content Type with alias "childDoc"
    public partial class ChildDoc : ParentDoc
    {
        public ChildDoc(IPublishedContent content)
            : base(content)
        { }

        public string Prop2
        {
            get { return this.Value<string>("prop2"); }
        }
    }

    // Content Type with alias "aaa"
    public partial class Aaa : ParentDoc
    {
        public Aaa(IPublishedContent content)
            : base(content)
        { }
    }

    // Content Type with alias "CrazyCTypeAlias"
    public partial class CrazyCTypeAlias : PublishedContentModel
    {
        public CrazyCTypeAlias(IPublishedContent content)
            : base(content)
        { }
    }

    // Content Type with alias "RtePage"
    public partial class RtePage : PublishedContentModel
    {
        public RtePage(IPublishedContent content)
            : base(content)
        { }

        public IHtmlString Rte
        {
            get { return this.Value<IHtmlString>("rte"); }
        }

        public IHtmlString SimpleText
        {
            get { return this.Value<IHtmlString>("simpleText"); }
        }
    }

    // Content Type with alias "SubRtePage"
    public partial class SubRtePage : RtePage
    {
        public SubRtePage(IPublishedContent content)
            : base(content)
        { }
    }

    // Content Type with alias "bbb"
    public partial class SpecialBbb : ParentDoc, IMixinTestRenamed
    {
        public SpecialBbb(IPublishedContent content)
            : base(content)
        { }

        public string MixinProp
        {
            get { return this.Value<string>("MixinProp"); }
        }
    }

    // Mixin Content Type with alias "MixinTest"
    public partial interface IMixinTestRenamed : IPublishedContent
    {
        string MixinProp { get; }
    }

    // Content Type with alias "MixinTest"
    public partial class MixinTestRenamed : PublishedContentModel, IMixinTestRenamed
    {
        public MixinTestRenamed(IPublishedContent content)
            : base(content)
        { }

        public string MixinProp
        {
            get { return this.Value<string>("MixinProp"); }
        }
    }

    /// <summary>DebugTextBuilder</summary>
    [PublishedModel("debugTextBuilder")]
    public partial class DebugTextBuilder : PublishedContentModel
    {
        // helpers
#pragma warning disable 0109 // new is redundant
        public new const string ModelTypeAlias = "debugTextBuilder";
        public new const PublishedItemType ModelItemType = PublishedItemType.Content;
        public new static IPublishedContentType GetModelContentType()
            => PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
        public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DebugTextBuilder, TValue>> selector)
            => PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

        // ctor
        public DebugTextBuilder(IPublishedContent content)
            : base(content)
        { }

        // properties
    }
}


