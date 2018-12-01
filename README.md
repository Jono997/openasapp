# OpenAsApp
An application that creates shortcuts for Google Chrome that open as if they were separate
applications.

## Why does this exist? Can't Chrome already do this?
Well, it could, but a couple of versions back (I don't know when), this functionality was removed.
All shortcuts created in the latest version of Chrome open as new tabs, but old shortcuts that were
configured to open separately still work as such. OpenAsApp creates shortcuts configured like that.

## How do I use OAA?
When you open OpenAsApp, you'll see two boxes. Copy and paste the URL of the first one into the
first text box and put the name of the shortcut into the second text box. Afterwards, click the
create shortcut button and the shortcut should then be made.

## I want to create one by hand instead of using OAA. How do I do this?
Well, you start by creating a shortcut in Chrome. Go to the site you want to make a shortcut of.
Be sure to keep note of the URL. You'll need this later (it's not in the shortcut).
Open the menu under the close button, select More Tools and click Create shortcut... Create the 
shortcut as normal, then go to your desktop and find that shortcut. Right click on it and click
Properties. From there, look through the Target parameter until you find the text, "--app-id=".
Delete this text and everything after it and replace it with "--app=" followed by the URL of the
site you want to go to.