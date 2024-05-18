using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ChromeBrowser;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        service.LogPath = "chromedriver.log";
        service.EnableVerboseLogging = true;

        // Create options for the Chrome driver
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized"); // Start browser maximized
        options.AddArgument("--disable-popup-blocking"); // Disable popup blocking
        options.AddArgument("incognito"); // Launches Chrome in incognito mode.
        options.AddArgument("start-maximized"); // Starts Chrome maximized to the screen.
        options.AddArgument("--window-size=1920,1080"); // Sets the initial window size.
        options.AddArgument("--disable-popup-blocking"); // Disables the popup blocking.
        options.AddArgument("--disable-default-apps"); // Disables installation of default apps on first run.
        options.AddArgument("--ignore-certificate-errors"); // Ignores certificate-related errors.
        options.AddArgument("--test-type"); // Allows for running Chrome in test mode.
        options.AddArgument("--disable-gpu"); // Disables GPU hardware acceleration.
        options.AddArgument("--no-sandbox"); // Disables the sandbox security for Chrome.
        options.AddArgument("--disable-dev-shm-usage"); // Solves an issue where Chrome crashes in Docker.
        options.AddArgument("--disable-extensions"); // Disables installed extensions.
        options.AddArgument("--disable-plugins-discovery"); // Disables plugin discovery.
        options.AddArgument("--start-fullscreen"); // Starts Chrome in fullscreen mode.
        options.AddArgument("--disable-infobars"); // Prevents infobars from appearing.
        options.AddArgument("--mute-audio"); // Mutes any audio playing.
        options.AddArgument("--no-first-run"); // Skips the first run experience.
        options.AddArgument("--disable-web-security"); // Disables web security.
        options.AddArgument("--allow-running-insecure-content"); // Allows running insecure content.
        options.AddArgument("--disable-auto-update"); // Disables Chrome auto update.
        options.AddArgument("--disable-translate"); // Disables the translation prompt.
        options.AddArgument("--disable-save-password-bubble"); // Disables the save password prompt.
        options.AddArgument("--disable-notifications"); // Disables the notifications.
        options.AddArgument("--disable-application-cache"); // Disables the application cache.
        options.AddArgument("--disable-offline-load-stale-cache"); // Disables loading a stale cache while offline.
        options.AddArgument("--disk-cache-size=0"); // Sets the disk cache size to 0.
        options.AddArgument("--v8-cache-options=off"); // Turns off caching of V8 compile data.
        options.AddArgument("--disable-cache"); // Disables the cache.
        options.AddArgument("--disable-databases"); // Disables databases.
        options.AddArgument("--disable-plugin-power-saver"); // Disables the plugin power saver.
        options.AddArgument("--disable-prompt-on-repost"); // Disables the prompt for reposting form data on refresh.
        options.AddArgument("--disable-background-networking"); // Disables various background network services.
        options.AddArgument("--disable-sync"); // Disables syncing to a Google Account.
        options.AddArgument("--disable-reporting"); // Disables reporting to UMA, but allows for certificate error reports.
        options.AddArgument("--metrics-recording-only"); // Forces the Metrics Service to only record metrics, not reporting them.
        options.AddArgument("--disable-default-apps"); // Disables installation of default apps on first run.
        options.AddArgument("--hide-scrollbars"); // Hides scrollbars on the web pages.
        options.AddArgument("--enable-logging"); // Enables logging.
        options.AddArgument("--log-level=0"); // Sets the logging level.
        options.AddArgument("--password-store=basic"); // Forces Chrome to use the 'basic' password store.
        options.AddArgument("--use-mock-keychain"); // Forces Chrome to use a mock keychain.
        options.AddArgument("--disable-hang-monitor"); // Disables the hang monitor.
        options.AddArgument("--disable-prompt-on-repost"); // Disables the prompt when navigating away from a page.
        options.AddArgument("--disable-client-side-phishing-detection"); // Disables the client-side phishing detection.
        options.AddArgument("--disable-component-update"); // Disables the component update.
        options.AddArgument("--disable-background-timer-throttling"); // Disables background timer throttling.
        options.AddArgument("--disable-backgrounding-occluded-windows"); // Disables occluded windows from going to the background.
        options.AddArgument("--disable-renderer-backgrounding"); // Disables renderer from going to the background.
        options.AddArgument("--disable-background-mode"); // Disables background mode.
        options.AddArgument("--enable-remote-extensions"); // Enables remote extensions.
        options.AddArgument("--disable-search-geolocation-disclosure"); // Disables disclosure of search geolocation.
        options.AddArgument("--allow-insecure-localhost"); // Allows insecure localhost.
        options.AddArgument("--disable-single-click-autofill"); // Disables autofill with a single click.
        options.AddArgument("--disable-suggestions-ui"); // Disables suggestions UI.
        options.AddArgument("--disable-save-password-bubble"); // Disables the save password bubble.
        options.AddArgument("--disable-first-run-ui"); // Disables the first run UI.
        options.AddArgument("--disable-background-tracing"); // Disables background tracing.
        options.AddArgument("--disable-breakpad"); // Disables the breakpad.
        options.AddArgument("--disable-cloud-import"); // Disables cloud import.
        options.AddArgument("--disable-dinosaur-easter-egg"); // Disables the dinosaur easter egg.
        options.AddArgument("--disable-domain-reliability"); // Disables domain reliability.
        options.AddArgument("--disable-download-notifications"); // Disables download notifications.
        // Create a new instance of the Chrome driver
        IWebDriver driver = new ChromeDriver(service, options);

        try
        {
            // Navigate to Google.com
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(5000);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            // The driver will be closed once the program exits
            driver.Quit();
        }
    }
}