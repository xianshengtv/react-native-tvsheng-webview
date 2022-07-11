module.exports = {
  dependencies: {
    // Help rn-cli find and autolink this library
    "react-native-tvsheng-webview": {
      root: __dirname,
    },
  },
  ...(project ? { project } : undefined),
};
