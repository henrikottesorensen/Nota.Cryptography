﻿/*
 * Copyright 2025 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Nota.Cryptography.Argon2;

public static class Argon2Constants
{
    public const int Argon2d = 0;

    public const int Argon2i = 1;

    public const int Argon2id = 2;

    public const int Version10 = 0x10;

    public const int Version13 = 0x13;

    public static class OpsLimit
    {
        public const int Interactive = 4;
        public const int Medium = 4;
        public const int Moderate = 6;
        public const int Sensitive = 8;
    }

    public static class MemoryLimit
    {
        public const int Interactive = 32 * 1024;
        public const int Medium = 64 * 1024;
        public const int Moderate = 128 * 1024;
        public const int Sensitive = 512 * 1024;
    }
}
