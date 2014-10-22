ATS IDE
=======

![](screenshots/screenshot_as_editor.png)

The goal is to create an IDE for ATS.

To install stable version:

* 1. Install Mono 3.x and MonoDevelop 5.x (see instructions from mono-project.com)
* 2. Go to add-in manager, and manually add a new repository

```
http://underivable.org/monodevelop/5.0
```

* 3. The ATS binding should appear in the list of language bindings, so you can install it.

To compile from git sources:

* 1. Install Mono 3.x and MonoDevelop 5.x
* 2. Fork this repo and clone it to your machine
* 3. Open the solution in MonoDevelop and hit "Compile" (in Debug configuration)
* 4. Open the terminal emulator of your choice, navigate to the solution directory, then type:

```
$ mdtool setup pack MonoDevelop.ATSBinding/bin/Debug/MonoDevelop.ATSBinding.addin.xml
```

* 5. There should be a file named MonoDevelop.ATSBinding_V.mpack (where V stands for version, e.g. 0.0.1), which you can install into MonoDevelop via the GUI menu: Tools -> Add-in Manager -> Install from file.

* 6. The plugin should just work.
