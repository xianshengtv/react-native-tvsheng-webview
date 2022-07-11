require 'json'

package = JSON.parse(File.read(File.join(__dir__, 'package.json')))

Pod::Spec.new do |s|
  s.name         = "react-native-tvsheng-webview"
  s.version      = package['version']
  s.summary      = package['description']
  s.license      = "MIT"

  s.authors      = "Tv Xiansheng <tvxiansheng@example.com>"
  s.homepage     = "https://github.com/xianshengtv/react-native-tvsheng-webview#readme"
  s.platforms    = { :ios => "11.0", :osx => "10.13" }
  s.requires_arc        = true
  s.source       = { :git => "https://github.com/xianshengtv/react-native-tvsheng-webview.git", :tag => "v#{s.version}" }
  s.source_files  = "ios/*.{h,m}"
  s.requires_arc        = true

  s.dependency 'React-Core'
end
