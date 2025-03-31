﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Core.Utilities
{
    public class AlgoForgeLogo
    {
        public static void DisplayCyberpunkGreeting()
        {
            string[] algoForgeLogo = {
                @":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::",
                @"::          _____                    _____            _____                   _______                                          ::",
                @"::         /\    \                  /\    \          /\    \                 /::\    \                                         ::",
                @"::        /::\    \                /::\____\        /::\    \               /::::\    \                                        ::",
                @"::       /::::\    \              /:::/    /       /::::\    \             /::::::\    \                                       ::",
                @"::      /::::::\    \            /:::/    /       /::::::\    \           /::::::::\    \                                      ::",
                @"::     /:::/\:::\    \          /:::/    /       /:::/\:::\    \         /:::/~~\:::\    \                                     ::",
                @"::    /:::/__\:::\    \        /:::/    /       /:::/  \:::\    \       /:::/    \:::\    \                                    ::",
                @"::   /::::\   \:::\    \      /:::/    /       /:::/    \:::\    \     /:::/    / \:::\    \                                   ::",
                @"::  /::::::\   \:::\    \    /:::/    /       /:::/    / \:::\    \   /:::/____/   \:::\____\                                  ::",
                @":: /:::/\:::\   \:::\    \  /:::/    /       /:::/    /   \:::\ ___\ |:::|    |     |:::|    |                                 ::",
                @"::/:::/  \:::\   \:::\____\/:::/____/       /:::/____/  ___\:::|    ||:::|____|     |:::|    |                                 ::",
                @"::\::/    \:::\  /:::/    /\:::\    \       \:::\    \ /\  /:::|____| \:::\    \   /:::/    /                                  ::",
                @":: \/____/ \:::\/:::/    /  \:::\    \       \:::\    /::\ \::/    /   \:::\    \ /:::/    /                                   ::",
                @"::          \::::::/    /    \:::\    \       \:::\   \:::\ \/____/     \:::\    /:::/    /                                    ::",
                @"::           \::::/    /      \:::\    \       \:::\   \:::\____\        \:::\__/:::/    /                                     ::",
                @"::           /:::/    /        \:::\    \       \:::\  /:::/    /         \::::::::/    /                                      ::",
                @"::          /:::/    /          \:::\    \       \:::\/:::/    /           \::::::/    /                                       ::",
                @"::         /:::/    /            \:::\    \       \::::::/    /             \::::/    /                                        ::",
                @"::        /:::/    /              \:::\____\       \::::/    /               \::/____/                                         ::",
                @"::        \::/    /                \::/    /        \::/____/                 ~~                                               ::",
                @"::         \/____/                  \/____/                                                                                    ::",
                @"::          _____                   _______                   _____                    _____                    _____          ::",
                @"::         /\    \                 /::\    \                 /\    \                  /\    \                  /\    \         ::",
                @"::        /::\    \               /::::\    \               /::\    \                /::\    \                /::\    \        ::",
                @"::       /::::\    \             /::::::\    \             /::::\    \              /::::\    \              /::::\    \       ::",
                @"::      /::::::\    \           /::::::::\    \           /::::::\    \            /::::::\    \            /::::::\    \      ::",
                @"::     /:::/\:::\    \         /:::/~~\:::\    \         /:::/\:::\    \          /:::/\:::\    \          /:::/\:::\    \     ::",
                @"::    /:::/__\:::\    \       /:::/    \:::\    \       /:::/__\:::\    \        /:::/  \:::\    \        /:::/__\:::\    \    ::",
                @"::   /::::\   \:::\    \     /:::/    / \:::\    \     /::::\   \:::\    \      /:::/    \:::\    \      /::::\   \:::\    \   ::",
                @"::  /::::::\   \:::\    \   /:::/____/   \:::\____\   /::::::\   \:::\    \    /:::/    / \:::\    \    /::::::\   \:::\    \  ::",
                @":: /:::/\:::\   \:::\    \ |:::|    |     |:::|    | /:::/\:::\   \:::\____\  /:::/    /   \:::\ ___\  /:::/\:::\   \:::\    \ ::",
                @"::/:::/  \:::\   \:::\____\|:::|____|     |:::|    |/:::/  \:::\   \:::|    |/:::/____/  ___\:::|    |/:::/__\:::\   \:::\____\::",
                @"::\::/    \:::\   \::/    / \:::\    \   /:::/    / \::/   |::::\  /:::|____|\:::\    \ /\  /:::|____|\:::\   \:::\   \::/    /::",
                @":: \/____/ \:::\   \/____/   \:::\    \ /:::/    /   \/____|:::::\/:::/    /  \:::\    /::\ \::/    /  \:::\   \:::\   \/____/ ::",
                @"::          \:::\    \        \:::\    /:::/    /          |:::::::::/    /    \:::\   \:::\ \/____/    \:::\   \:::\    \     ::",
                @"::           \:::\____\        \:::\__/:::/    /           |::|\::::/    /      \:::\   \:::\____\       \:::\   \:::\____\    ::",
                @"::            \::/    /         \::::::::/    /            |::| \::/____/        \:::\  /:::/    /        \:::\   \::/    /    ::",
                @"::             \/____/           \::::::/    /             |::|  ~|               \:::\/:::/    /          \:::\   \/____/     ::",
                @"::                                \::::/    /              |::|   |                \::::::/    /            \:::\    \         ::",
                @"::                                 \::/____/               \::|   |                 \::::/    /              \:::\____\        ::",
                @"::                                  ~~                      \:|   |                  \::/____/                \::/    /        ::",
                @"::                                                           \|___|                                            \/____/         ::",
                @":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::"
            };

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (string line in algoForgeLogo)
            {
                //Thread.Sleep(100);
                Console.WriteLine(line);
                //Thread.Sleep(150);
            }
            Console.ResetColor();

            ////// Wait for user input
            ////Console.ReadLine();

        }
    }
}
