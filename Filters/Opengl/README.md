# Filters in OpenGL
### Heavily adapted from [learnopengl.com](https://learnopengl.com)
### [learnopengl.com](https://learnopengl.com) tutorials used:
* Creating a Window
* Hello Window
* Hello Triangle
* Shaders
* Textures
* Framebuffers

All of my work for this project is contained in `src/main.cpp`, `src/shader.vs`, `src/hshader.fs`, `src/screen.vs`, and `src/screen.fs`, although parts of these files are heavily adapted from the aforementioned examples.

## Build Instructions (Ubuntu 20.04)
1. Install dependencies

```$ sudo apt install libglfw3-dev```

If g++, libc, libstdc++, libX11, libdl, make are not installed, they will also need to be installed.

2. Clone repository

```$ git clone https://github.com/Daniel-E-B/cs280-computer-vision.git```

3. Run make

```$ cd cs280-computer-vision/Filters/Opengl```

```$ mkdir build```

```$ make```

4. Run project

```$ build/main```

Build instructions for other environments can be found at [learnopengl.com/Getting-started/Creating-a-window](https://learnopengl.com/Getting-started/Creating-a-window)
## How it works

The core of the program are the two shaders, `src/hshader.fs` and `src/screen.fs`. The former applies an average blur filter horizontally while the latter applies one vertically.

In `src/main.cpp`, a framebuffer is used to run the horizontal shader on the input texture and draw the result to an intermediate texture. The vertical (screen) shader is then run on the intermediate texture and drawn to the screen. Then, some fun transformations are applied.

By running the shaders with an intermediate texture, the number of samples taken per pixel is reduced from 101^2 to 2*101 which greatly improves speed.
