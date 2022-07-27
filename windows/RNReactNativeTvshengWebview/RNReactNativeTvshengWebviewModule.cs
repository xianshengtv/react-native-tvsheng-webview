using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Tvsheng.Webview.RNReactNativeTvshengWebview
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeTvshengWebviewModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeTvshengWebviewModule"/>.
        /// </summary>
        internal RNReactNativeTvshengWebviewModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeTvshengWebview";
            }
        }
    }
}
