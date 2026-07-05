# Endless Driving Game - Unity Assignment

## Overview

This project is a mobile-optimized endless driving game inspired by Dashy Crashy. The objective is to survive as long as possible by avoiding obstacles while driving through an infinite procedurally generated road.

The project is developed in Unity using the Universal Render Pipeline (URP) with a focus on performance, clean architecture, and stylized visuals.

---

## Unity Version

Unity 6.x (URP)

---

## Features

### Core Gameplay
- Endless procedurally generated road
- Lane-based car movement
- Obstacle spawning system
- Collision detection
- Distance-based gameplay
- Game Over system
- Restart functionality

### Environment
- Infinite road generation
- Stylized environment assets
- Day/Night skybox transition
- Optimized lighting using baked lighting

### Vehicle
- Stylized car visuals
- Smooth movement
- Camera follow system

### Visual Improvements
- Stylized road shader
- Emissive road lane markings
- Bright, high-contrast color palette
- Mobile-friendly URP materials

### Optimization
- Mobile optimized
- GPU Instancing enabled where applicable
- Baked lighting
- Reduced real-time lighting
- Optimized textures
- Optimized materials
- Low-overhead shaders

---

## Controls

### Mobile
- Swipe Left → Move Left
- Swipe Right → Move Right

### Editor
- Left Arrow / A → Move Left
- Right Arrow / D → Move Right

---

## Project Structure

```
Assets/
│
├── Scripts/
├── Prefabs/
├── Materials/
├── Textures/
├── Shaders/
├── Scenes/
├── Models/
└── Audio/
```

---

## Shader

A custom Shader Graph shader is used for the road.

Features include:

- Texture tiling support
- Adjustable UV scaling
- Emissive lane markings
- Custom glow intensity
- Mobile-friendly implementation

---

## Optimization Techniques

- Baked Global Illumination
- Single Directional Light
- GPU Instancing
- Texture Atlasing where possible
- Shared Materials
- Optimized Meshes
- Reduced Draw Calls
- Mobile-friendly URP settings

---

## How to Run

1. Open the project in Unity.
2. Open the Main Scene.
3. Press Play in the Editor.

For Android:

1. Switch Build Platform to Android.
2. Build and Run on a connected device.

---

## Assets Used

- Custom stylized road texture
- Custom road Shader Graph
- Vehicle model
- Environment assets
- Unity URP

---

## Future Improvements

- Score system
- Coins and collectibles
- Power-ups
- Multiple vehicles
- Sound effects and background music
- Leaderboard
- Vehicle customization

---

## Work Completed

- Designed and assembled the gameplay level
- Implemented endless road generation
- Implemented player movement
- Added obstacle spawning and collision detection
- Implemented day/night environment transition
- Created a custom Shader Graph road shader with emissive lane markings
- Optimized the project for mobile performance
- Configured baked lighting and URP settings
- Created stylized road textures


---

## Author

**Harsh Bishnoi**

Unity Developer Assignment
