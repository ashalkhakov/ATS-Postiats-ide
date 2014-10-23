ATS IDE
=======

![](screenshots/screenshot_as_editor.png)

The goal is to create an IDE for ATS.

## Install stable version

To install stable version:

* 1. Install Mono 3.x and MonoDevelop 5.x (see instructions from mono-project.com)
* 2. Go to add-in manager, and manually add a new repository


    http://underivable.org/monodevelop/5.0


* 3. The ATS binding should appear in the list of language bindings (in the top menu:), so you can install it.

## Compile from sources

To compile from git sources:

* 1. Install Mono 3.x and MonoDevelop 5.x
* 2. Fork this repo and clone it to your machine
* 3. To install in MonoDevelop:

````
$ make install
````

If you ever need to release a package:

````
$ make release
````

You will also have to put the resulting "repository" directory on a
webserver.