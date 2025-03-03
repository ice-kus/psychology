﻿using Psychology.Data.Interfaces;
using Psychology.Data.Models;
using System.Collections.Generic;

namespace Psychology.Data.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly ApplicationDbContext DB;
        public AnswerRepository(ApplicationDbContext DB)
        {
            this.DB = DB;
        }
        public IEnumerable<Answer> List => DB.Answer;
        public void Create(string Text)
        {
            DB.Answer.Add
            (
            new Answer
            {
                Text = Text
            }
            );
        }
        public void Update(Answer Answer)
        {
            DB.Answer.Update(Answer);
        }
        public void Delete(long Id)
        {
            try
            {
                DB.Answer.Remove(DB.Answer.Find(Id));
            }
            catch
            {
                DB.ChangeTracker.Clear();
            }
        }
        public bool Save()
        {
            try
            {
                DB.SaveChanges();
            }
            catch
            {
                DB.ChangeTracker.Clear();
                return false;
            }
            return true;
        }
    }
}
