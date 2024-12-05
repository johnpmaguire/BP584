# Blazor Puzzle #58

## Multi-Tenant State

YouTube Video: https://youtu.be/A9_2rwenKkU

Blazor Puzzle Home Page: https://blazorpuzzle.com

### The Challenge:

In this demo, we have created an architecture that lets us customize the experience for our different clients. In the real world, the client would be decided based on the login or some other method, but we simply have buttons on the main screen to switch between clients.

We want to use an application state component for each client, but we don't want to cascade it around the entire app, as we have done in previous episodes and on BlazorTrain.

Instead, we want to create a state component for each client, and be able to access it as a scoped parameter in all the pages in each client. 

How can we provide customized state components for each client and maintain that state across client pages?
