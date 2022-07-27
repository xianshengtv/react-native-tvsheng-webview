using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Tvsheng.Webview.RNTvshengWebview
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTvshengWebviewModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTvshengWebviewModule"/>.
        /// </summary>
        internal RNTvshengWebviewModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTvshengWebview";
            }
        }
    }
}
