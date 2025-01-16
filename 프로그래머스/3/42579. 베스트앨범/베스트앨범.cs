using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
       public class Song
    {
        public int PlayCount { get; set; }
        public int Index { get; set; }

        public Song(int playCount, int index)
        {
            PlayCount = playCount;
            Index = index;
        }
    }

    public  int[] solution(string[] genres, int[] plays)
    {  
        // 1. 장르별 총 재생 횟수 계산
        Dictionary<string, int> genrePlayCounts = new Dictionary<string, int>();
        Dictionary<string, List<Song>> genreSongs = new Dictionary<string, List<Song>>();

        for (int i = 0; i < genres.Length; i++)
        {
            string genre = genres[i];
            int playCount = plays[i];

            // 장르별 총 재생 횟수
            if (!genrePlayCounts.ContainsKey(genre))
            {
                genrePlayCounts[genre] = 0;
                genreSongs[genre] = new List<Song>();
            }
            genrePlayCounts[genre] += playCount;

            // 장르별 노래 목록 저장 (재생 횟수, 고유 번호)
            genreSongs[genre].Add(new Song(playCount, i));
        }

        // 2. 장르별 총 재생 횟수 기준으로 정렬
        var sortedGenres = genrePlayCounts
            .OrderByDescending(g => g.Value)
            .Select(g => g.Key);

        List<int> answer = new List<int>();

        // 3. 각 장르에서 가장 많이 재생된 두 곡 선택
        foreach (var genre in sortedGenres)
        {
            var songs = genreSongs[genre]
                .OrderByDescending(s => s.PlayCount)    // 재생 횟수 내림차순
                .ThenBy(s => s.Index)                   // 고유 번호 오름차순
                .Take(2);                               // 최대 두 곡 선택

            foreach (var song in songs)
            {
                answer.Add(song.Index);
            }
        }

        return answer.ToArray();
    }
    
}