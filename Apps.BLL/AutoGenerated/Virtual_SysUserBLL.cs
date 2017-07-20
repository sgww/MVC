//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Apps.Models;
using Apps.Models.Sys;
using Apps.IBLL;
using Apps.IDAL;
using Microsoft.Practices.Unity;
using Apps.Common;
using Apps.BLL.Core;

namespace Apps.BLL
{
	public class Virtual_SysUserBLL 
	{
		[Dependency]
        public ISysUserRepository m_Rep { get; set; }

		public DBContainer db = new DBContainer();
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pager">JQgrid分页</param>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>列表</returns>
        public virtual List<SysUserModel> GetList(ref GridPager pager,string queryStr)
        {

            IQueryable<SysUser> queryData = null;
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = m_Rep.GetList(
										a => (a.Id != null && a.Id.Contains(queryStr))
															|| (a.UserName != null && a.UserName.Contains(queryStr))
														|| (a.Password != null && a.Password.Contains(queryStr))
														|| (a.TrueName != null && a.TrueName.Contains(queryStr))
														|| (a.Card != null && a.Card.Contains(queryStr))
														|| (a.MobileNumber != null && a.MobileNumber.Contains(queryStr))
														|| (a.PhoneNumber != null && a.PhoneNumber.Contains(queryStr))
														|| (a.QQ != null && a.QQ.Contains(queryStr))
														|| (a.EmailAddress != null && a.EmailAddress.Contains(queryStr))
														|| (a.OtherContact != null && a.OtherContact.Contains(queryStr))
														|| (a.Province != null && a.Province.Contains(queryStr))
														|| (a.City != null && a.City.Contains(queryStr))
														|| (a.Village != null && a.Village.Contains(queryStr))
														|| (a.Address != null && a.Address.Contains(queryStr))
														
														
														|| (a.CreatePerson != null && a.CreatePerson.Contains(queryStr))
														|| (a.Sex != null && a.Sex.Contains(queryStr))
														
														
														|| (a.Marital != null && a.Marital.Contains(queryStr))
														|| (a.Political != null && a.Political.Contains(queryStr))
														|| (a.Nationality != null && a.Nationality.Contains(queryStr))
														|| (a.Native != null && a.Native.Contains(queryStr))
														|| (a.School != null && a.School.Contains(queryStr))
														|| (a.Professional != null && a.Professional.Contains(queryStr))
														|| (a.Degree != null && a.Degree.Contains(queryStr))
														|| (a.DepId != null && a.DepId.Contains(queryStr))
														|| (a.PosId != null && a.PosId.Contains(queryStr))
														|| (a.Expertise != null && a.Expertise.Contains(queryStr))
														|| (a.JobState != null && a.JobState.Contains(queryStr))
														|| (a.Photo != null && a.Photo.Contains(queryStr))
														|| (a.Attach != null && a.Attach.Contains(queryStr))
								);
            }
            else
            {
                queryData = m_Rep.GetList();
            }
            pager.totalRows = queryData.Count();
            queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
            List<SysUserModel> modelList = (from r in queryData
                                              select new SysUserModel
                                              {
                                                 													 Id = r.Id,
                                                  													 UserName = r.UserName,
                                                  													 Password = r.Password,
                                                  													 TrueName = r.TrueName,
                                                  													 Card = r.Card,
                                                  													 MobileNumber = r.MobileNumber,
                                                  													 PhoneNumber = r.PhoneNumber,
                                                  													 QQ = r.QQ,
                                                  													 EmailAddress = r.EmailAddress,
                                                  													 OtherContact = r.OtherContact,
                                                  													 Province = r.Province,
                                                  													 City = r.City,
                                                  													 Village = r.Village,
                                                  													 Address = r.Address,
                                                  													 State = r.State,
                                                  													 CreateTime = r.CreateTime,
                                                  													 CreatePerson = r.CreatePerson,
                                                  													 Sex = r.Sex,
                                                  													 Birthday = r.Birthday,
                                                  													 JoinDate = r.JoinDate,
                                                  													 Marital = r.Marital,
                                                  													 Political = r.Political,
                                                  													 Nationality = r.Nationality,
                                                  													 Native = r.Native,
                                                  													 School = r.School,
                                                  													 Professional = r.Professional,
                                                  													 Degree = r.Degree,
                                                  													 DepId = r.DepId,
                                                  													 PosId = r.PosId,
                                                  													 Expertise = r.Expertise,
                                                  													 JobState = r.JobState,
                                                  													 Photo = r.Photo,
                                                  													 Attach = r.Attach,
                                                  
                                              }).ToList();
            return modelList;
        }
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public virtual bool Create(ref ValidationErrors errors, SysUserModel model)
        {
            try
            {
                SysUser entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.add(Suggestion.PrimaryRepeat);
                    return false;
                }
                entity = new SysUser();
                					entity.Id = model.Id;
                    					entity.UserName = model.UserName;
                    					entity.Password = model.Password;
                    					entity.TrueName = model.TrueName;
                    					entity.Card = model.Card;
                    					entity.MobileNumber = model.MobileNumber;
                    					entity.PhoneNumber = model.PhoneNumber;
                    					entity.QQ = model.QQ;
                    					entity.EmailAddress = model.EmailAddress;
                    					entity.OtherContact = model.OtherContact;
                    					entity.Province = model.Province;
                    					entity.City = model.City;
                    					entity.Village = model.Village;
                    					entity.Address = model.Address;
                    					entity.State = model.State;
                    					entity.CreateTime = model.CreateTime;
                    					entity.CreatePerson = model.CreatePerson;
                    					entity.Sex = model.Sex;
                    					entity.Birthday = model.Birthday;
                    					entity.JoinDate = model.JoinDate;
                    					entity.Marital = model.Marital;
                    					entity.Political = model.Political;
                    					entity.Nationality = model.Nationality;
                    					entity.Native = model.Native;
                    					entity.School = model.School;
                    					entity.Professional = model.Professional;
                    					entity.Degree = model.Degree;
                    					entity.DepId = model.DepId;
                    					entity.PosId = model.PosId;
                    					entity.Expertise = model.Expertise;
                    					entity.JobState = model.JobState;
                    					entity.Photo = model.Photo;
                    					entity.Attach = model.Attach;
                    
                if (m_Rep.Create(entity))
                {
                    return true;
                }
                else
                {
                    errors.add("插入失败");
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.add(ex.Message);
                ExceptionHandler.WriteException(ex);
                //ExceptionHander.WriteException(ex);
                return false;
            }
        }
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="id">id</param>
        /// <returns>是否成功</returns>
        public virtual bool Delete(ref ValidationErrors errors, string id)
        {
            try
            {
                if (m_Rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    errors.add(Suggestion.DeleteFail);
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.add(ex.Message);
                ExceptionHandler.WriteException(ex);
                return false;
            }
        }

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public virtual bool Edit(ref ValidationErrors errors, SysUserModel model)
        {
            try
            {
                SysUser entity = m_Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.add(Suggestion.Disable);
                    return false;
                }
                					entity.Id = model.Id;
                    					entity.UserName = model.UserName;
                    					entity.Password = model.Password;
                    					entity.TrueName = model.TrueName;
                    					entity.Card = model.Card;
                    					entity.MobileNumber = model.MobileNumber;
                    					entity.PhoneNumber = model.PhoneNumber;
                    					entity.QQ = model.QQ;
                    					entity.EmailAddress = model.EmailAddress;
                    					entity.OtherContact = model.OtherContact;
                    					entity.Province = model.Province;
                    					entity.City = model.City;
                    					entity.Village = model.Village;
                    					entity.Address = model.Address;
                    					entity.State = model.State;
                    					entity.CreateTime = model.CreateTime;
                    					entity.CreatePerson = model.CreatePerson;
                    					entity.Sex = model.Sex;
                    					entity.Birthday = model.Birthday;
                    					entity.JoinDate = model.JoinDate;
                    					entity.Marital = model.Marital;
                    					entity.Political = model.Political;
                    					entity.Nationality = model.Nationality;
                    					entity.Native = model.Native;
                    					entity.School = model.School;
                    					entity.Professional = model.Professional;
                    					entity.Degree = model.Degree;
                    					entity.DepId = model.DepId;
                    					entity.PosId = model.PosId;
                    					entity.Expertise = model.Expertise;
                    					entity.JobState = model.JobState;
                    					entity.Photo = model.Photo;
                    					entity.Attach = model.Attach;
                    


                if (m_Rep.Edit(entity))
                {
                    return true;
                }
                else
                {
                    errors.add(Suggestion.EditFail);
                    return false;
                }

            }
            catch (Exception ex)
            {
                errors.add(ex.Message);
                ExceptionHandler.WriteException(ex);
                //ExceptionHander.WriteException(ex);
                return false;
            }
        }
        /// <summary>
        /// 判断是否存在实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>是否存在</returns>
        public virtual bool IsExist(string id)
        {
            return m_Rep.IsExist(id);
        }
        /// <summary>
        /// 根据ID获得一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        public virtual SysUserModel GetById(string id)
        {
            if (IsExist(id))
            {
                SysUser entity = m_Rep.GetById(id);
                SysUserModel model = new SysUserModel();
                					 model.Id = entity.Id;
                    					 model.UserName = entity.UserName;
                    					 model.Password = entity.Password;
                    					 model.TrueName = entity.TrueName;
                    					 model.Card = entity.Card;
                    					 model.MobileNumber = entity.MobileNumber;
                    					 model.PhoneNumber = entity.PhoneNumber;
                    					 model.QQ = entity.QQ;
                    					 model.EmailAddress = entity.EmailAddress;
                    					 model.OtherContact = entity.OtherContact;
                    					 model.Province = entity.Province;
                    					 model.City = entity.City;
                    					 model.Village = entity.Village;
                    					 model.Address = entity.Address;
                    					 model.State = entity.State;
                    					 model.CreateTime = entity.CreateTime;
                    					 model.CreatePerson = entity.CreatePerson;
                    					 model.Sex = entity.Sex;
                    					 model.Birthday = entity.Birthday;
                    					 model.JoinDate = entity.JoinDate;
                    					 model.Marital = entity.Marital;
                    					 model.Political = entity.Political;
                    					 model.Nationality = entity.Nationality;
                    					 model.Native = entity.Native;
                    					 model.School = entity.School;
                    					 model.Professional = entity.Professional;
                    					 model.Degree = entity.Degree;
                    					 model.DepId = entity.DepId;
                    					 model.PosId = entity.PosId;
                    					 model.Expertise = entity.Expertise;
                    					 model.JobState = entity.JobState;
                    					 model.Photo = entity.Photo;
                    					 model.Attach = entity.Attach;
                    
                return model;
            }
            else
            {
                return null;
            }
        }
	}
}
