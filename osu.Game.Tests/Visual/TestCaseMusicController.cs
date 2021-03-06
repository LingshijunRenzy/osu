﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using NUnit.Framework;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Timing;
using osu.Game.Overlays;

namespace osu.Game.Tests.Visual
{
    [TestFixture]
    public class TestCaseMusicController : OsuTestCase
    {
        public TestCaseMusicController()
        {
            Clock = new FramedClock();

            var mc = new MusicController
            {
                Origin = Anchor.Centre,
                Anchor = Anchor.Centre
            };
            Add(mc);

            AddToggleStep(@"toggle visibility", state => mc.State = state ? Visibility.Visible : Visibility.Hidden);
            AddStep(@"show", () => mc.State = Visibility.Visible);
            AddToggleStep(@"toggle beatmap lock", state => Beatmap.Disabled = state);
        }
    }
}
