/*
 * Copyright (c) Contributors, http://aurora-sim.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the Aurora-Sim Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.Collections;

using key = Aurora.ScriptEngine.AuroraDotNetEngine.LSL_Types.LSLString;
using rotation = Aurora.ScriptEngine.AuroraDotNetEngine.LSL_Types.Quaternion;
using vector = Aurora.ScriptEngine.AuroraDotNetEngine.LSL_Types.Vector3;
using LSL_List = Aurora.ScriptEngine.AuroraDotNetEngine.LSL_Types.list;
using LSL_String = Aurora.ScriptEngine.AuroraDotNetEngine.LSL_Types.LSLString;
using LSL_Integer = Aurora.ScriptEngine.AuroraDotNetEngine.LSL_Types.LSLInteger;
using LSL_Float = Aurora.ScriptEngine.AuroraDotNetEngine.LSL_Types.LSLFloat;
using LSL_Vector = Aurora.ScriptEngine.AuroraDotNetEngine.LSL_Types.Vector3;
using OpenMetaverse;

namespace Aurora.BotManager
{
    public interface IBot_Api
    {
        LSL_Vector botGetWaitingTime (LSL_Integer waitTime);
        void botSetMap(string keyOfBot, LSL_List positions, LSL_List movementType, LSL_Integer flags);
        string botCreateBot (string FirstName, string LastName, string appearanceToClone, LSL_Vector startPos);
        void botRemoveBot (string bot);
        void botPauseMovement (string bot);
        void botResumeMovement (string bot);
        void botFollowAvatar (string bot, string avatarName, LSL_Float startFollowDistance, LSL_Float endFollowDistance);
        void botStopFollowAvatar (string bot);
        void botSetPathMap (string bot, string pathMap, int x, int y, int cornerstoneX, int cornerstoneY);
        void botFindPath (string bot, LSL_Vector startPos, LSL_Vector endPos);
        void botSendChatMessage (string bot, string message, int sayType, int channel);
        void botSetShouldFly (string keyOfBot, int ShouldFly);
        void botSitObject (string bot, string objectID, LSL_Vector offset);
        void botStandUp (string bot);
        void botTouchObject (string bot, string objectID);
        void botAddTag (string bot, string tag);
        LSL_List botGetBotsWithTag (string tag);
        void botRemoveBotsWithTag (string tag);
        string botGetLocation(string bot);
        void botAnimate(string bot, string AnimationUUID);
        void botSetState(string bot, string State);
        string botGetState(string bot);
        string botSpawnAttackBot(string FirstName, string LastName, string appearanceToClone, string AvatarToFollowName, string creatorID);
        
        void botCauseDamage(string sBotName, float fdamage);
        //<Christy Lock Code>
        //Incoming chat from an object or an avatar    //botListenMessage
        void botListenMessage(string fromName, string bot, string message, int sayType, string pos);
        void botTeleportTo(string bot, string pos);
        //</Christy Lock Code>

    }
}
