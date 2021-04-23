using System;
using System.Collections.Generic;
using oop_2021.replay;
using oop_2021.utility;
using Xunit;

namespace oop_2021.Test

{
    public class ReplayTest
    {
        
        [Fact]
        public void ReplayTest1()
        {
            ReplayData replay = new ReplayDataBuilder()
                .Date(DateTime.Now)
                .GameType(new GameType())
                .MatchId("10")
                .WhiteUser(new User())
                .BlackUser(new User())
                .Boards(new List<Board>())
                .Build();
            Assert.Equal("10", replay.MatchId);
        }


        [Fact]
        public void ReplayTest2()
        {
            ReplayData replay = new ReplayDataBuilder()
                .Date(DateTime.Now)
                .GameType(new GameType())
                .MatchId("10")
                .WhiteUser(new User())
                .BlackUser(new User())
                .Boards(new List<Board>())
                .Build();

            ISavedReplay myReplay = new SavedReplayInRam();
            myReplay.Save(replay);
            Assert.Equal("10", myReplay.GetSavedReplay("10").MatchId);
        }



    }
}
