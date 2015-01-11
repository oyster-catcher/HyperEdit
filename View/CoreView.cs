﻿using UnityEngine;

namespace HyperEdit.View
{
    public class CoreView : View
    {
        public static void Create()
        {
            var view = new CoreView();
            Window.Create("HyperEdit", true, true, 100, -1, view.Draw);
        }

        private CoreView()
        {
        }

        public override void Draw(Window window)
        {
            base.Draw(window);
            if (GUILayout.Button(new GUIContent("Close all", "Closes all windows")))
                Window.CloseAll();
            if (GUILayout.Button(new GUIContent("Orbit Editor", "Opens the Orbit Editor window")))
                CreateView(new Model.OrbitEditor());
            if (GUILayout.Button(new GUIContent("Planet Editor", "Opens the Planet Editor window")))
                CreateView(new Model.PlanetEditor());
            if (GUILayout.Button(new GUIContent("Ship Lander", "Opens the Ship Lander window")))
                LanderView.Create();
            if (GUILayout.Button(new GUIContent("Misc Tools", "Opens the Misc Tools window")))
                MiscEditorView.Create();
            if (GUILayout.Button(new GUIContent("About", "Opens the About window")))
                AboutWindow.Create();
        }
    }
}
