MDTOOL=mdtool
XBUILD=xbuild
NS=MonoDevelop
N=ATSBinding
VER=0.0.1
NAME=$(NS).$(N)
PKG=repository/$(NAME)_$(VER).mpack
CONF=Debug
DLL=MonoDevelop.ATSBinding/bin/$(CONF)/$(NAME).dll
.PHONY: main restore clean install uninstall release
main: $(PKG)
$(PKG): $(DLL)
	$(MDTOOL) setup pack $(DLL)
	mv *.mpack repository/
	$(DLL): $(NAME) restore
	$(XBUILD) /p:Configuration=$(CONF)
install: $(PKG)
	$(MDTOOL) setup install -y $(PKG)
uninstall:
	$(MDTOOL) setup uninstall -y $(NAME)
clean:
	$(XBUILD) /p:Configuration=$(CONF) /target:Clean
	rm -rf $(PKG)
packages:
	echo nothing here yet
restore: packages
release: $(PKG)
	mkdir -p repository
	$(MDTOOL) setup rep-build repository/
