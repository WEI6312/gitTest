# EMS




## 一、修改记录



|   时间    | 版本 | 内容 |
| :-------: | :--: | :--: |
| 2020.1.14 | 1.0  | 创建 |



## 二、接口列表



### 一、公用功能

#### 1.登录

**简要描述**

- 登录

**请求URL**

- http://115.159.208.36:60094/user/login

**请求方式**

- GET

**参数**

| 参数名   | 必选 | 类型   | 说明         |
| -------- | ---- | ------ | ------------ |
| account  | 是   | String | 账户         |
| password | 是   | String | 密码返回示例 |

**返回示例**

```json
{
    "stasus": 1,
    "user": {
        "Id": 1,
        "Name": "root",
        "Account": "root",
        "Password": "root",
        "User_level": 0,
        "WorkcelID": 1,
        "Phone": 123457671,
        "E_mail": "1253362157@qq.com",
        "Avatar": "avatar",
        "Entry_time": "2020-01-13T21:01:10",
        "Age": 37,
        "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJJZCI6MSwiRXhwaXJ5VGltZSI6IjIwMjAtMDEtMTRUMTc6MDI6MDYuMTU1MTM3MyswODowMCJ9.04mNrWDfcAQjGa2PjAG8YFbNkWNA7qEXf1ryguAOo_4",
        "ExpiryTime": "2020-01-14T17:02:06.1551373+08:00"
    }
}
```



#### 2.获取用户信息

**简要描述**

- 获取用户信息

**请求URL**

- http://115.159.208.36:60094/user/getUserInfo

**请求方式**

- GET

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**参数**

| 参数名 | 必选 | 类型 | 说明   |
| ------ | ---- | ---- | ------ |
| id     | 是   | int  | 用户id |

**返回示例**

```json
{
    "stasus": 1,
    "user": {
        "Id": 1,
        "Name": "root",
        "Account": "root",
        "Password": "root",
        "User_level": 0,
        "WorkcelID": 1,
        "Phone": 123457671,
        "E_mail": "1253362157@qq.com",
        "Avatar": "avatar",
        "Entry_time": "2020-01-13T21:01:10",
        "Age": 37,
        "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJJZCI6MSwiRXhwaXJ5VGltZSI6IjIwMjAtMDEtMTRUMTc6MDI6MDYuMTU1MTM3MyswODowMCJ9.04mNrWDfcAQjGa2PjAG8YFbNkWNA7qEXf1ryguAOo_4",
        "ExpiryTime": "2020-01-14T17:02:06.1551373+08:00"
    }
}
```





#### 3.修改用户信息

**请求URL**

- http://115.159.208.36:60094/user/modifyUser

**请求方式**

- POST

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**参数**

| 参数名     | 必选 | 类型   | 说明     |
| ---------- | ---- | ------ | -------- |
| Name       | 是   | string | 用户名   |
| Account    | 是   | string | 账号     |
| password   | 是   | string | 密码     |
| user_level | 是   | int    | 用户权限 |
| workcellD  | 是   | int    | 部门id   |
| phone      | 是   | int    | 电话     |
| e_mail     | 否   | string | 邮箱     |
| avatar     | 否   | string | 头像     |
| entry_time | 是   | date   | 入职时间 |
| age        | 否   | int    | 年龄     |



**返回示例**

```json
{
    "stasus": 1,
    "user": {
        "Id": 1,
        "Name": "root",
        "Account": "root",
        "Password": "root",
        "User_level": 0,
        "WorkcelID": 1,
        "Phone": 123457671,
        "E_mail": "1253362157@qq.com",
        "Avatar": "avatar",
        "Entry_time": "2020-01-13T21:01:10",
        "Age": 37,
        "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJJZCI6MSwiRXhwaXJ5VGltZSI6IjIwMjAtMDEtMTRUMTc6MDI6MDYuMTU1MTM3MyswODowMCJ9.04mNrWDfcAQjGa2PjAG8YFbNkWNA7qEXf1ryguAOo_4",
        "ExpiryTime": "2020-01-14T17:02:06.1551373+08:00"
    }
}
```





#### 4.上传图片

**请求URL**

- http://115.159.208.36:60094/user/uploadPicture

**请求方式**

- POST

**参数**

| 参数名 | 必选 | 类型 | 说明 |
| ------ | ---- | ---- | ---- |
| file   | 是   | file | 图片 |



**返回示例**

```json
{
    "status": true,
    "url": "http://115.159.208.36:60094/App_Data/Pictures/20200115115014_5043.png"
}
```



#### 5.查看夹具信息

**请求URL**

- http://115.159.208.36:60094/user/getFixtureById

**请求方式**

- GET

**参数**

| 参数名 | 必选 | 类型 | 说明   |
| ------ | ---- | ---- | ------ |
| id     | 是   | int  | 夹具id |



**返回示例**

```json
{
    "status": true,
    "url": "http://115.159.208.36:60094/App_Data/Pictures/20200115115014_5043.png"
}
```





### 二、管理员

#### 1.添加用户

**请求URL**

- http://115.159.208.36:60094/admin/newUser

**请求方式**

- POST

**请求头**

| 参数名 | 必选 | 类型   | 说明  |
| ------ | ---- | ------ | ----- |
| id     | 是   | int    | id    |
| auth   | 是   | string | token |

**参数**

| 参数名     | 必选 | 类型   | 说明     |
| ---------- | ---- | ------ | -------- |
| Name       | 是   | string | 用户名   |
| Account    | 是   | string | 账号     |
| password   | 是   | string | 密码     |
| user_level | 是   | int    | 用户权限 |
| workcellD  | 是   | int    | 部门id   |
| phone      | 是   | int    | 电话     |
| e_mail     | 否   | string | 邮箱     |
| avatar     | 否   | string | 头像     |
| entry_time | 是   | date   | 入职时间 |
| age        | 否   | int    | 年龄     |

**返回示例**

```json
{
    "stasus": 1,
    "message": "创建成功"
}
```



#### 2.查看全部用户

**请求URL**

- http://115.159.208.36:60094/user/getUsers

**请求方式**

- GET

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名 | 必选 | 类型 | 说明 |
| ------ | ---- | ---- | ---- |
| page   | 否   | int  | 页数 |



**返回示例**

```json
{
    "stasus": 1,
    "li": [
        {
            "Id": 1,
            "Name": "root",
            "Account": "root",
            "Password": "root",
            "User_level": 0,
            "WorkcelID": 1,
            "Phone": 123457671,
            "E_mail": "1253362157@qq.com",
            "Avatar": "avatar",
            "Entry_time": "2020-01-14T16:33:38",
            "Age": 37,
            "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJJZCI6MSwiRXhwaXJ5VGltZSI6IjIwMjAtMDEtMTVUMTU6MzQ6NTkuMDc4NTUzOSswODowMCJ9.9bZ2wlpLmLVWlkhnvaks5fbxhHnYMksNTScdLcW5Mxs",
            "ExpiryTime": "2020-01-15T15:34:59"
        },
        {
            "Id": 2,
            "Name": "user1",
            "Account": "123456789",
            "Password": "123",
            "User_level": 0,
            "WorkcelID": 1,
            "Phone": 123457671,
            "E_mail": "1253362157@qq.com",
            "Avatar": "avatar",
            "Entry_time": "2020-01-14T16:33:39",
            "Age": 37,
            "Token": null,
            "ExpiryTime": null
        }
    ]
}
```



#### 3.查看部门用户

**请求URL**

- http://115.159.208.36:60094/user/getUserByWorkcell

**请求方式**

- GET

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名     | 必选 | 类型 | 说明   |
| ---------- | ---- | ---- | ------ |
| workcellID | 是   | int  | 部门id |
| page       | 否   | int  | 页数   |



**返回示例**

```json
{
    "stasus": 1,
    "li": [
        {
            "Id": 1,
            "Name": "root",
            "Account": "root",
            "Password": "root",
            "User_level": 0,
            "WorkcelID": 1,
            "Phone": 123457671,
            "E_mail": "1253362157@qq.com",
            "Avatar": "avatar",
            "Entry_time": "2020-01-14T16:33:38",
            "Age": 37,
            "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJJZCI6MSwiRXhwaXJ5VGltZSI6IjIwMjAtMDEtMTVUMTU6MzQ6NTkuMDc4NTUzOSswODowMCJ9.9bZ2wlpLmLVWlkhnvaks5fbxhHnYMksNTScdLcW5Mxs",
            "ExpiryTime": "2020-01-15T15:34:59"
        },
        {
            "Id": 2,
            "Name": "user1",
            "Account": "123456789",
            "Password": "123",
            "User_level": 0,
            "WorkcelID": 1,
            "Phone": 123457671,
            "E_mail": "1253362157@qq.com",
            "Avatar": "avatar",
            "Entry_time": "2020-01-14T16:33:39",
            "Age": 37,
            "Token": null,
            "ExpiryTime": null
        }
    ]
}
```



#### 4.查看权限用户

**请求URL**

- http://115.159.208.36:60094/user/getUserByLevel

**请求方式**

- GET

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名 | 必选 | 类型 | 说明     |
| ------ | ---- | ---- | -------- |
| level  | 是   | int  | 用户权限 |
| page   | 否   | int  | 页数     |



**返回示例**

```json
{
    "stasus": 1,
    "li": [
        {
            "Id": 1,
            "Name": "root",
            "Account": "root",
            "Password": "root",
            "User_level": 0,
            "WorkcelID": 1,
            "Phone": 123457671,
            "E_mail": "1253362157@qq.com",
            "Avatar": "avatar",
            "Entry_time": "2020-01-14T16:33:38",
            "Age": 37,
            "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJJZCI6MSwiRXhwaXJ5VGltZSI6IjIwMjAtMDEtMTVUMTU6MzQ6NTkuMDc4NTUzOSswODowMCJ9.9bZ2wlpLmLVWlkhnvaks5fbxhHnYMksNTScdLcW5Mxs",
            "ExpiryTime": "2020-01-15T15:34:59"
        },
        {
            "Id": 2,
            "Name": "user1",
            "Account": "123456789",
            "Password": "123",
            "User_level": 0,
            "WorkcelID": 1,
            "Phone": 123457671,
            "E_mail": "1253362157@qq.com",
            "Avatar": "avatar",
            "Entry_time": "2020-01-14T16:33:39",
            "Age": 37,
            "Token": null,
            "ExpiryTime": null
        }
    ]
}
```



#### 5.名字模糊搜索用户

**请求URL**

- http://115.159.208.36:60094/user/getUserByName

**请求方式**

- GET

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| name   | 是   | string | 用户名 |
| page   | 否   | int    | 页数   |



**返回示例**

```json
{
    "stasus": 1,
    "li": [
        {
            "Id": 1,
            "Name": "root",
            "Account": "root",
            "Password": "root",
            "User_level": 0,
            "WorkcelID": 1,
            "Phone": 123457671,
            "E_mail": "1253362157@qq.com",
            "Avatar": "avatar",
            "Entry_time": "2020-01-14T16:33:38",
            "Age": 37,
            "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJJZCI6MSwiRXhwaXJ5VGltZSI6IjIwMjAtMDEtMTVUMTU6MzQ6NTkuMDc4NTUzOSswODowMCJ9.9bZ2wlpLmLVWlkhnvaks5fbxhHnYMksNTScdLcW5Mxs",
            "ExpiryTime": "2020-01-15T15:34:59"
        },
        {
            "Id": 2,
            "Name": "user1",
            "Account": "123456789",
            "Password": "123",
            "User_level": 0,
            "WorkcelID": 1,
            "Phone": 123457671,
            "E_mail": "1253362157@qq.com",
            "Avatar": "avatar",
            "Entry_time": "2020-01-14T16:33:39",
            "Age": 37,
            "Token": null,
            "ExpiryTime": null
        }
    ]
}
```



#### 6.删除用户

**请求URL**

- http://115.159.208.36:60094/user/deleteUser

**请求方式**

- DELETE

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名 | 必选 | 类型 | 说明   |
| ------ | ---- | ---- | ------ |
| id     | 是   | int  | 用户id |



**返回示例**

```json
{
    "stasus": 1,
    "message": "删除成功"
}
```



#### 7.修改用户信息

* 同接口1.3



### 三、初级用户
#### 1.根据status查看工夹具实体信息
**请求url**
- http://115.159.208.36:60094/operatori/fixturelist

**请求方式**

- GET

**请求头**

| 参数名 | 必选 | 类型   | 说明  |
| ------ | ---- | ------ | ----- |
| id     | 是   | int    | id    |
| auth   | 是   | string | token |

**请求参数**

| 参数名     | 必选 | 类型   | 说明     |
| ---------- | ---- | ------ | -------- |
| status     | 是   | int    | 工夹具状态   |

**返回示例**

```json
{
    "stasus": 1,
    "fxli": [
        {
            "code": "EF0789",
            "seqID": 1,
            "billNo": "BO19070500000002",
            "RegDate": "2019-07-05T16:42:43",
            "UsedCount": 3,
            "locationID": 1,
            "picture": "E:\\avatar\\default.jpg",
            "status": 0,
            "buyoff": "B804156",
            "ProduceDate": "2020-01-17T15:04:47",
            "name": "MOD 3XM2 陶瓷组装夹具",
            "usefor": "陶瓷组装",
            "familyID": 79,
            "RecUID": 1
        },
        {
            "code": "EF0789",
            "seqID": 2,
            "billNo": "BO19070500000001",
            "RegDate": "2019-07-05T16:42:43",
            "UsedCount": 32,
            "locationID": 1,
            "picture": "E:\\avatar\\default.jpg",
            "status": 0,
            "buyoff": "B804157",
            "ProduceDate": "2020-01-17T15:04:51",
            "name": "MOD 3XM2 陶瓷组装夹具",
            "usefor": "陶瓷组装",
            "familyID": 79,
            "RecUID": 1
        }
    ]
}

```

备注：status ：0 空闲 ，1 使用 ，3 报修 ，4 维修

#### 2.提交出库请求

**请求URL**
- http://115.159.208.36:60094/operatori/lendApply

**请求方式**

- POST

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名     | 必选 | 类型   | 说明     |
| ---------- | ---- | ------ | -------- |
| userID     | 是   | int    | 用户id   |
| giveTo     | 是   | string | 经手人   |
| productionlineID    | 是   | int    | 产线id   |
| lendDate    | 是   | date    | 出库时间   |

**返回示例**

```json
{
    "stasus": 1,
    "message": "出库成功",
    "lendID":1
}
```

#### 3.提交出库夹具请求

**请求URL**
- http://115.159.208.36:60094/operatori/lenddetail

**请求方式**

- POST

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名     | 必选 | 类型   | 说明     |
| ---------- | ---- | ------ | -------- |
| lendID     | 是   | int    | 3.2返回的lendID   |
| list     | 是   | int[] | 夹具的id的list   |

**返回示例**

```json
{
    "stasus": 1,
    "message": "添加成功"
}
```

#### 4.显示已出库夹具信息

**请求URL**
- http://115.159.208.36:60094/operatori/getlend

**请求方式**

- GET

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |


**返回示例**

```json
{
    "stasus": 1,
    "lend": [
        {
            "id": 1,
            "userID": 1,
            "giveTo": "cxk",
            "productionlineID": 1,
            "lendDate": "2020-01-18T11:40:12",
            "code": "EF2189",
            "seqID": 1
        },
        {
            "id": 1,
            "userID": 1,
            "giveTo": "cxk",
            "productionlineID": 1,
            "lendDate": "2020-01-18T11:40:12",
            "code": "EF2189",
            "seqID": 2
        }
    ]
}
```




### 四、高级用户

#### 1.获取夹具列表

* 接口3.1

#### 2.提交入库申请

**请求URL**

- http://115.159.208.36:60094/operatorii/postInApply

**请求方式**

- POST

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名     | 必选 | 类型   | 说明     |
| ---------- | ---- | ------ | -------- |
| userID     | 是   | int    | 用户id   |
| name       | 是   | string | 夹具名   |
| modelID    | 是   | int    | 模组id   |
| partNo     | 是   | int    | 料号id   |
| code       | 是   | string | 夹具编码 |
| billNo     | 是   | string | 订单号   |
| apply_date | 是   | date   | 申请日期 |
| picture    | 是   | string | 图片url  |
| buyoff     | 是   | string | 接受编号 |



**返回示例**

```json
{
    "stasus": 1,
    "message": "提交成功"
}
```



#### 3.修改夹具信息

**请求URL**

- http://115.159.208.36:60094/operatorii/modifyFixture

**请求方式**

- PUT

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名     | 必选 | 类型   | 说明   |
| ---------- | ---- | ------ | ------ |
| id         | 是   | int    | 夹具id |
| locationID | 否   | int    | 库位id |
| picture    | 否   | string | 图片   |



**返回示例**

```json
{
    "stasus": 1,
    "fixture": {
        "Id": 1,
        "Code": "EF2189",
        "SeqID": 1,
        "BillNo": "111",
        "RegDate": "2018-07-07T11:11:00",
        "UsedCount": 1,
        "LocationID": 1,
        "Picture": "url",
        "Status": 0,
        "Buyoff": "temp"
    }
}
```



#### 4.获取报修申请列表

**请求URL**

- http://115.159.208.36:60094/operatorii/getRepairApplyByStatus

**请求方式**

- GET

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名 | 必选 | 类型 | 说明     |
| ------ | ---- | ---- | -------- |
| status | 是   | int  | 夹具状态 |



**返回示例**

```json
{
    "stasus": 1,
    "li": [
        {
            "Id": 1,
            "UserID": 1,
            "SeqID": 1,
            "Code": "1",
            "Problem": "p",
            "Post_time": "2018-07-07T11:11:11",
            "Photo": "url",
            "Status": false
        },
        {
            "Id": 2,
            "UserID": 1,
            "SeqID": 2,
            "Code": "2",
            "Problem": "p2",
            "Post_time": "2018-07-07T19:11:11",
            "Photo": "url2",
            "Status": false
        }
    ],
    "message": "成功"
}
```



#### 5.接受报修申请

**请求URL**

- http://115.159.208.36:60094/operatorii/acceptRepairApply

**请求方式**

- POST

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名 | 必选 | 类型 | 说明       |
| ------ | ---- | ---- | ---------- |
| id     | 是   | int  | 报修申请id |
| userId | 是   | int  | 申请人id   |



**返回示例**

```json
{
    "stasus": 1,
    "message": "接受成功"
}
```



#### 6.完成报修申请

**请求URL**

- http://115.159.208.36:60094/operatorii/finishRepairApply

**请求方式**

- PUT

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名 | 必选 | 类型 | 说明       |
| ------ | ---- | ---- | ---------- |
| id     | 是   | int  | 报修申请id |



**返回示例**

```json
{
    "stasus": 1,
    "message": "提交成功"
}
```



#### 7.申请报废

**请求URL**

- http://115.159.208.36:60094/operatorii/applyForScrap

**请求方式**

- POST

**请求头**

| 参数名 | 必选 | 类型   | 说明   |
| ------ | ---- | ------ | ------ |
| id     | 是   | int    | 用户id |
| auth   | 是   | string | token  |

**请求参数**

| 参数名    | 必选 | 类型   | 说明       |
| --------- | ---- | ------ | ---------- |
| userID    | 是   | int    | 用户id     |
| seqID     | 是   | int    | 夹具序列号 |
| code      | 是   | string | 夹具编码   |
| reason    | 是   | string | 原因       |
| post_date | 是   | date   | 申请日期   |
| photo     | 是   | string | 图片url    |



**返回示例**

```json
{
    "stasus": 1,
    "message": "提交成功"
}
```



#### 8.查看报修历史







### 五、监管员

#### 1.创建工夹具类别



#### 2.获取工夹具类别



#### 3.修改工夹具类别



#### 4.处理采购入库申请



#### 5.处理采购入库申请



#### 6.获取报废申请



#### 7.处理报废申请



#### 8.查看采购入库审核记录



#### 9.查看报废处理申请



#### 10.获取夹具列表

* 接口1.5



### 六、经理

#### 1.获取夹具列表

* 接口1.1



#### 2.获取待二次审核的采购申请列表



#### 3.审核采购申请



#### 4.审核采购历史记录列表



#### 5.获取待二次审核的报废申请



#### 6.审核报废申请



#### 7.审核采购历史记录列表
