import Vue from 'vue';
import Toasted from 'vue-toasted';

Vue.use(Toasted, {
  position: 'top-right', // Set popup position (choose any valid option)
  theme: 'toasted-primary', // Adjust theme (explore available themes)
  duration: 4000, // Control popup display duration
  keepOnHover: true,
  fitToScreen: true,
  iconPack: 'fontawesome',
});
