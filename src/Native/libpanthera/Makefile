# Create shared library libpanthera.so from static library librandomx.a using --whole-archive

CC = g++
LDFLAGS = -shared -pthread -L. -Wl,-whole-archive librandomx.a -Wl,-no-whole-archive -Wl,-z,noexecstack
LDLIBS = -lstdc++ -lgcc -lc
TARGET  = libpanthera.so

all: $(TARGET)

$(TARGET): $(OBJECTS)
	$(CC) $(CXXFLAGS) $(CPPFLAGS) $(LDFLAGS) -o $@ $^ $(LDLIBS)

.PHONY: clean

clean:
	find . -name '*.o' -exec rm -r {} \;
	rm -f libpanthera.so
