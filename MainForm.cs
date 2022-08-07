using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebkitBuildOptionsGenerator
{
    public partial class MainForm : Form
    {

        List<Option> featureOptions = new List<Option>();
        List<Option> buildOptions = new List<Option>();
        public MainForm()
        {
            InitializeComponent();

            CreateBuildOptions();

            CreateFeatureOptions();
        }

        public void CreateBuildOptions()
        {
            buildOptions.Add(new Option("--verbose", "Show verbose build output"));
            buildOptions.Add(new Option("--clean", "Cleanup the build directory"));
            buildOptions.Add(new Option("--generate-project-only", "Only generate project files"));
            buildOptions.Add(new Option("--debug", "Compile with Debug configuration"));
            buildOptions.Add(new Option("--release", "Compile with Release configuration"));
            buildOptions.Add(new Option("--sdk=<sdk>", "Use a specific Xcode SDK (Apple platforms only)"));
            buildOptions.Add(new Option("--ios-device", "Use \"iphoneos.internal\" SDK if installed, else \"iphoneos\" SDK (iOS only)"));
            buildOptions.Add(new Option("--device","DEPRECATED alias of buildOptions.Add(new Option(\"--ios-device\")"));
            buildOptions.Add(new Option("--ios-simulator","Use \"iphonesimulator.internal\" SDK if installed, else \"iphonesimulator\" SDK (iOS only)"));
            buildOptions.Add(new Option("--simulator","DEPRECATED alias of buildOptions.Add(new Option(\"--ios-simulator\")"));
            buildOptions.Add(new Option("--tvos-device","Use \"appletvos.internal\" SDK if installed, else \"appletvos\" SDK (tvOS only)\")"));
            buildOptions.Add(new Option("--tvos-simulator","Use \"appletvsimulator\" (tvOS only)"));
            buildOptions.Add(new Option("--watchos-device","Use \"watchos.internal\" SDK if installed, else \"watchos\" SDK (watchOS only)"));
            buildOptions.Add(new Option("--watchos-simulator","Use \"watchsimulator\" (watchOS only)"));
            buildOptions.Add(new Option("--coverage","Enable code coverage support (Mac only)"));
            buildOptions.Add(new Option("--analyze","Enable static anaylsis (Apple platforms only)"));
            buildOptions.Add(new Option("--lto-mode=<mode>","Set Link Time Optimization mode (full, thin, or none) (LLVM only)"));
            buildOptions.Add(new Option("--no-use-workspace","Build projects one at a time instead of using WebKit.xcworkspace (Apple platforms only)"));
            buildOptions.Add(new Option("--ftw","Build the FTW Windows port"));
            buildOptions.Add(new Option("--gtk","Build the GTK+ port"));
            buildOptions.Add(new Option("--wpe","Build the WPE port"));
            buildOptions.Add(new Option("--wincairo","Build using Cairo (rather than CoreGraphics) on Windows"));
            buildOptions.Add(new Option("--playstation","Build the PlayStation port"));
            buildOptions.Add(new Option("--inspector-frontend","Copy Web Inspector user interface resources to the build directory"));
            buildOptions.Add(new Option("--prefix=<path>","Set installation prefix to the given path (CMake only, except Windows)"));
            buildOptions.Add(new Option("--makeargs=<arguments>","Optional Makefile flags"));
            buildOptions.Add(new Option("--cmakeargs=<arguments>","One or more optional CMake flags (e.g. buildOptions.Add(new Option(\"--cmakeargs= \"-DFOO=bar -DCMAKE_PREFIX_PATH=/usr/local\")"));
            buildOptions.Add(new Option("--minimal","No optional features, unless explicitly enabled"));
            buildOptions.Add(new Option("--no-experimental-features","No experimental features, unless explicitly enabled (CMake only)"));
            buildOptions.Add(new Option("--only-webkit","Build only the WebKit project"));
            buildOptions.Add(new Option("--skip-library-update","Skip the check to see if windows libraries are up to date"));
            buildOptions.Add(new Option("--[no-]use-ccache","Enable (or disable) CCache, if available"));
            buildOptions.Add(new Option("--export-compile-commands","Generate compile_commands.json (Apple platforms only)"));

            lvBuild.Items.Clear();
            for (int i = 0; i < buildOptions.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(buildOptions[i].Name);
                lvi.SubItems.Add(buildOptions[i].Description);
                lvi.Checked = buildOptions[i].Selected;
                lvBuild.Items.Add(lvi);
            }

            lvBuild.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void CreateFeatureOptions()
        {
            featureOptions.Add(new Option("3d-rendering", "Toggle 3D rendering support"));
            featureOptions.Add(new Option("accessibility-isolated-tree", "Toggle accessibility isolated tree support"));
            featureOptions.Add(new Option("apple-pay", "Toggle Apply Pay support"));
            featureOptions.Add(new Option("apple-pay-session-v9", "Toggle Apple Pay Session V9 support"));
            featureOptions.Add(new Option("application-manifest", "Toggle Application Manifest support"));
            featureOptions.Add(new Option("async-scrolling","Enable asynchronous scrolling"));
            featureOptions.Add(new Option("attachment-element", "Toggle Attachment Element support"));
            featureOptions.Add(new Option("autocapitalize", "Toggle autocapitalize support"));
            featureOptions.Add(new Option("avf-captions", "Toggle AVFoundation caption support"));
            featureOptions.Add(new Option("bubblewrap-sandbox", "Toggle Bubblewrap sandboxing support"));
            featureOptions.Add(new Option("cache-partitioning", "Toggle cache partitioning support"));
            featureOptions.Add(new Option("channel-messaging", "Toggle Channel Messaging support"));
            featureOptions.Add(new Option("content-extensions", "Toggle Content Extensions support"));
            featureOptions.Add(new Option("content-filtering", "Toggle content filtering support"));
            featureOptions.Add(new Option("context-menus", "Toggle Context Menu support"));
            featureOptions.Add(new Option("css-box-decoration-break", "Toggle CSS box-decoration-break support"));
            featureOptions.Add(new Option("css-compositing", "Toggle CSS Compositing support"));
            featureOptions.Add(new Option("css-conic-gradients", "Toggle CSS Conic Gradient support"));
            featureOptions.Add(new Option("css-device-adaptation", "Toggle CSS Device Adaptation support"));
            featureOptions.Add(new Option("css-image-resolution", "Toggle CSS image-resolution support"));
            featureOptions.Add(new Option("css-painting-api", "Toggle CSS Painting API support"));
            featureOptions.Add(new Option("css-selectors-level4", "Toggle CSS Selectors Level 4 support"));
            featureOptions.Add(new Option("css-typed-om", "Toggle CSS Typed OM support"));
            featureOptions.Add(new Option("cursor-visibility", "Toggle cursor visibility support"));
            featureOptions.Add(new Option("cloop", "Enable CLoop interpreter"));
            featureOptions.Add(new Option("dark-mode-css", "Toggle Dark Mode CSS support"));
            featureOptions.Add(new Option("datacue-value", "Toggle datacue value support"));
            featureOptions.Add(new Option("datalist-element", "Toggle Datalist Element support"));
            featureOptions.Add(new Option("device-orientation", "Toggle Device Orientation support"));
            featureOptions.Add(new Option("dfg-jit", "Toggle data flow graph JIT tier"));
            featureOptions.Add(new Option("download-attribute", "Toggle Download Attribute support"));
            featureOptions.Add(new Option("drag-support", "Toggle support of drag actions (including selection of text with mouse"));
            featureOptions.Add(new Option("encrypted-media", "Toggle EME V3 support"));
            featureOptions.Add(new Option("filters-level-2", "Toggle Filters Module Level 2"));
            featureOptions.Add(new Option("ftl-jit", "Toggle FTL JIT support"));
            featureOptions.Add(new Option("ftpdir", "Toggle FTP Directory support"));
            featureOptions.Add(new Option("fullscreen-api", "Toggle Fullscreen API support"));
            featureOptions.Add(new Option("gamepad", "Toggle Gamepad support"));
            featureOptions.Add(new Option("geolocation", "Toggle Geolocation support"));
            featureOptions.Add(new Option("gpu-process", "Toggle GPU Process support"));
            featureOptions.Add(new Option("input-type-color", "Toggle Input Type Color support"));
            featureOptions.Add(new Option("input-type-date", "Toggle Input Type Date support"));
            featureOptions.Add(new Option("input-type-datetimelocal", "Toggle Input Type Datetimelocal support"));
            featureOptions.Add(new Option("input-type-month", "Toggle Input Type Month support"));
            featureOptions.Add(new Option("input-type-time", "Toggle Input Type Time support"));
            featureOptions.Add(new Option("input-type-week", "Toggle Input Type Week support"));
            featureOptions.Add(new Option("inspector-alternate-dispatchers", "Toggle inspector alternate dispatchers support"));
            featureOptions.Add(new Option("inspector-telemetry", "Toggle inspector telemetry support"));
            featureOptions.Add(new Option("intelligent-tracking-prevention", "Toggle intelligent tracking prevention support"));
            featureOptions.Add(new Option("ios-gesture-events", "Toggle iOS gesture events support"));
            featureOptions.Add(new Option("ios-touch-events", "Toggle iOStouch events support"));
            featureOptions.Add(new Option("jit", "Toggle JustInTime JavaScript support"));
            featureOptions.Add(new Option("layer-based-svg-engine", "Toggle Layer Based SVG Engine support"));
            featureOptions.Add(new Option("layout-formatting-context", "Toggle Layout Formatting Context support"));
            featureOptions.Add(new Option("llvm-profile-generation","Include LLVM's instrumentation To generate profiles for PGO"));
            featureOptions.Add(new Option("legacy-custom-protocol-manager", "Toggle legacy protocol manager support"));
            featureOptions.Add(new Option("legacy-encrypted-media", "Toggle Legacy EME V2 support"));
            featureOptions.Add(new Option("letterpress", "Toggle letterpress support"));
            featureOptions.Add(new Option("mac-gesture-events", "Toggle Mac gesture events support"));
            featureOptions.Add(new Option("mathml", "Toggle MathML support"));
            featureOptions.Add(new Option("media-capture", "Toggle Media Capture support"));
            featureOptions.Add(new Option("media-controls-script", "Toggle definition of media controls in Javascript"));
            featureOptions.Add(new Option("media-source", "Toggle Media Source support"));
            featureOptions.Add(new Option("media-statistics", "Toggle Media Statistics support"));
            featureOptions.Add(new Option("media-stream", "Toggle Media Stream support"));
            featureOptions.Add(new Option("memory-sampler", "Toggle Memory Sampler support"));
            featureOptions.Add(new Option("mhtml", "Toggle MHTML support"));
            featureOptions.Add(new Option("mouse-cursor-scale", "Toggle Scaled mouse cursor support"));
            featureOptions.Add(new Option("navigator-standalone", "Toogle standalone navigator support"));
            featureOptions.Add(new Option("netscape-plugin-api", "Toggle Netscape Plugin API support"));
            featureOptions.Add(new Option("network-cache-speculative-revalidation", "Toogle network cache speculative revalidation support"));
            featureOptions.Add(new Option("network-cache-stale-while-revalidate", "Toggle network cache stale-while-revalidate caching strategy"));
            featureOptions.Add(new Option("notifications", "Toggle Notifications support"));
            featureOptions.Add(new Option("offscreen-canvas", "Toggle OffscreenCanvas support"));
            featureOptions.Add(new Option("offscreen-canvas-in-workers", "Toggle OffscreenCanvas in Workers support"));
            featureOptions.Add(new Option("thunder", "Toggle Thunder CDM support"));
            featureOptions.Add(new Option("orientation-events", "Toggle Orientation Events support"));
            featureOptions.Add(new Option("overflow-scrolling-touch","Toggle accelerated scrolling support"));
            featureOptions.Add(new Option("payment-request", "Toggle Payment Request support"));
            featureOptions.Add(new Option("pdfkit-plugin", "Toggle PDFKit plugin support"));
            featureOptions.Add(new Option("picture-in-picture-api", "Toggle Picture-in-Picture API support"));
            featureOptions.Add(new Option("pointer-lock", "Toggle pointer lock support"));
            featureOptions.Add(new Option("public-suffix-list", "Toggle public suffix list support"));
            featureOptions.Add(new Option("remote-inspector", "Toggle remote inspector support"));
            featureOptions.Add(new Option("resolution-media-query", "Toggle resolution media query support"));
            featureOptions.Add(new Option("resource-usage", "Toggle resource usage support"));
            featureOptions.Add(new Option("rubber-banding", "Toggle rubber banding support"));
            featureOptions.Add(new Option("sampling-profiler", "Toggle sampling profiler support"));
            featureOptions.Add(new Option("sandbox-extensions", "Toggle sandbox extensions support"));
            featureOptions.Add(new Option("server-preconnect", "Toggle server preconnect support"));
            featureOptions.Add(new Option("service-controls", "Toggle service controls support"));
            featureOptions.Add(new Option("service-worker", "Toggle Service Worker support"));
            featureOptions.Add(new Option("shareable-resource", "Toggle network shareable resources support"));
            featureOptions.Add(new Option("smooth-scrolling", "Toggle smooth scrolling"));
            featureOptions.Add(new Option("speech-synthesis", "Toggle Speech Synthesis API support"));
            featureOptions.Add(new Option("spellcheck", "Toggle Spellchecking support (requires Enchant)"));
            featureOptions.Add(new Option("telephone-number-detection", "Toggle telephone number detection support"));
            featureOptions.Add(new Option("text-autosizing", "Toggle automatic text size adjustment support"));
            featureOptions.Add(new Option("touch-events", "Toggle touch Events support"));
            featureOptions.Add(new Option("touch-slider", "Toggle touch Slider support"));
            featureOptions.Add(new Option("unified-builds", "Toggle unified builds"));
            featureOptions.Add(new Option("user-message-handlers", "Toggle user script message handler support"));
            featureOptions.Add(new Option("variation-fonts", "Toggle variation fonts support"));
            featureOptions.Add(new Option("video", "Toggle Video support"));
            featureOptions.Add(new Option("video-presentation-mode", "Toggle Video presentation mode support"));
            featureOptions.Add(new Option("video-uses-element-fullscreen", "Toggle video element fullscreen support"));
            featureOptions.Add(new Option("webassembly", "Toggle WebAssembly support"));
            featureOptions.Add(new Option("webassembly-b3jit", "Toggle WebAssembly B3 JIT support"));
            featureOptions.Add(new Option("webdriver", "Toggle WebDriver service process"));
            featureOptions.Add(new Option("webdriver-keyboard-interactions", "Toggle WebDriver keyboard interactions"));
            featureOptions.Add(new Option("webdriver-mouse-interactions", "Toggle WebDriver mouse interactions"));
            featureOptions.Add(new Option("webdriver-touch-interactions", "Toggle WebDriver touch interactions"));
            featureOptions.Add(new Option("webdriver-wheel-interactions", "Toggle WebDriver wheel interactions"));
            featureOptions.Add(new Option("webgl", "Toggle WebGL support"));
            featureOptions.Add(new Option("webgl2", "Toggle WebGL2 support"));
            featureOptions.Add(new Option("webxr", "Toggle WebXR support"));
            featureOptions.Add(new Option("web-api-statistics", "Toggle Web API statistics support"));
            featureOptions.Add(new Option("web-audio", "Toggle Web Audio support"));
            featureOptions.Add(new Option("web-authn", "Toggle Web AuthN support"));
            featureOptions.Add(new Option("web-crypto", "Toggle WebCrypto Subtle-Crypto support"));
            featureOptions.Add(new Option("web-rtc", "Toggle WebRTC support"));
            featureOptions.Add(new Option("wireless-playback-target", "Toggle wireless playback target support"));
            featureOptions.Add(new Option("xslt", "Toggle XSLT support"));
            featureOptions.Add(new Option("gstreamer-gl", "Toggle GStreamer GL support"));
            featureOptions.Add(new Option("iso-malloc", "Toggle IsoMalloc support"));
            featureOptions.Add(new Option("system-malloc", "Toggle system allocator instead of bmalloc"));

            lvFeatures.Items.Clear();
            for (int i = 0; i < featureOptions.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(featureOptions[i].Name);
                lvi.SubItems.Add(featureOptions[i].Description);
                lvi.Checked = featureOptions[i].Selected;
                lvFeatures.Items.Add(lvi);
            }

            lvFeatures.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }


        public void ParseOptions(string options)
        {
            List<string> opt = options.Split(" ").ToList();
            
            foreach (var item in opt)
            {
                //build
                for (int i = 0; i < lvBuild.Items.Count; i++)
                {
                    if (lvBuild.Items[i].Text.ToLower() == item.ToLower())
                    {
                        lvBuild.Items[i].Checked = true;
                    }
                }

                //feature
                for (int i = 0; i < lvFeatures.Items.Count; i++)
                {
                    if (lvFeatures.Items[i].Text.ToLower() == item.ToLower().Replace("--",string.Empty))
                    {
                        lvFeatures.Items[i].Checked = true;
                    }
                }
            } 
        }

        private void btnGenerateCmdLnOpt_Click(object sender, EventArgs e)
        {
            string s = GenerateCommandLineOptions();
            txtOuput.Text = s;
        }

        private string GenerateCommandLineOptions()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lvBuild.CheckedItems.Count; i++)
            {
                sb.Append($"{lvBuild.CheckedItems[i].Text} ");
            }

            if (chkExplicitNo.Checked)
            {
                for (int i = 0; i < lvFeatures.Items.Count; i++)
                {
                    string c = lvFeatures.Items[i].Checked ? "" : "no-";
                    string s = $"--{c}{lvFeatures.Items[i].Text} ";
                    sb.Append(s);
                }
            }
            else
            {
                for (int i = 0; i < lvFeatures.CheckedItems.Count; i++)
                {
                    string s = $"--{lvFeatures.Items[i].Text} ";
                    sb.Append(s);
                }
            }

            return sb.ToString();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvFeatures.Items)
            {
                item.Checked = true;
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvFeatures.Items)
            {
                item.Checked = false;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvFeatures.Items)
            {
                item.Checked = !item.Checked;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var sd = new SaveFileDialog())
            {
                sd.DefaultExt = ".txt";
                sd.AddExtension = true;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sd.FileName, txtOuput.Text);
                }
            }
        }

        private void loadOptionsFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = string.Empty;
            using (var od = new OpenFileDialog())
            { 
                if (od.ShowDialog() == DialogResult.OK)
                {
                    content = File.ReadAllText(od.FileName);

                    //clear all checkoxes
                    foreach (ListViewItem item in lvBuild.Items)
                    {
                        item.Checked = false;
                    }
                    foreach (ListViewItem item in lvFeatures.Items)
                    {
                        item.Checked = false;
                    }

                    //load options as best match
                    ParseOptions(content);
                }
            }
        }
    }


    public class Option
    {
        public Option(string name, string description, bool selected = false)
        {
            Name = name;
            Description = description;
            Selected = selected;
        }

        public string Name { get; private set; }
        public string Description { get; }
        public bool Selected { get; }
    }
}
