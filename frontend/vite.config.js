import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";

// https://vite.dev/config/
export default defineConfig({
  plugins: [react()],
  server: {
    proxy: {
      "/questions": {
        target: "http://localhost:5026",
        changeOrigin: true,
      },
      "/highscores": {
        target: "http://localhost:5026",
        changeOrigin: true,
      },
    },
  },
});
