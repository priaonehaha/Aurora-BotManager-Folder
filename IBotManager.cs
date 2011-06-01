using System;
using System.Collections.Generic;
using OpenSim.Framework;
using OpenMetaverse;

namespace Aurora.BotManager
{
    public enum TravelMode { Walk, Fly, None };

    public interface IBotManager
    {
        UUID CreateAvatar (string FirstName, string LastName, IScene scene, UUID cloneAppearanceFrom);
        void SetBotMap(UUID Bot, List<Vector3> Positions, List<TravelMode> mode);
        void UnpauseAutoMove(UUID Bot);
        void PauseAutoMove(UUID Bot);
        void StopAutoMove(UUID Bot);
        void EnableAutoMove(UUID Bot);
        void SetMovementSpeedMod(UUID Bot, float modifier);
        void RemoveAvatar (UUID Bot, IScene iScene);

        #region Path following

        void ReadMap (UUID botID, string map, int X, int Y, int CornerStoneX, int CornerStoneY);
        void FindPath (UUID botID, Vector3 currentPos, Vector3 finishVector);

        #endregion

        #region FollowAvatar

        void FollowAvatar (UUID botID, string avatarName, float followDistance);
        void StopFollowAvatar (UUID botID);

        #endregion

        #region Chat

        void SendChatMessage (UUID botID, string message, int sayType, int channel);

        #endregion

        void SetBotShouldFly (UUID Bot, bool shouldFly);
        UUID SpawnAttackBot(string FirstName, string LastName, IScene s, UUID cloneAppearanceFrom, string AvatarToFollowName);
        void KillBot(UUID BotID);
        
    }

    /// <summary>
    /// Created by RealXtend
    /// </summary>
    public interface IRexBot
    {
        void SetPath (NavMesh mesh, int startNode, bool reverse, int timeOut, bool teleportToStart);
        void PauseAutoMove ();
        void StopAutoMove ();
        void EnableAutoMove ();
        void UnpauseAutoMove ();
        void SetMovementSpeedMod (float speed);
        void DisableWalk ();
        void EnableWalk ();
        void ReadMap (string filename, int X, int Y, int CornerStoneX, int CornerStoneY);
        void FindPath (Vector3 currentPos, Vector3 finishVector);
        void FollowAvatar (string avatarName, float followDistance);
        void StopFollowAvatar ();
        void SendChatMessage (int sayType, string message, int channel);
        void SetAttackBotToFollow(string avatarName);
        void Die();
        int Health
        {
            get;
            set;
        }
        
        
    }
}
