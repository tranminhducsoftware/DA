import React, { useEffect, useState, createRef } from "react";
import classNames from "classnames";
import {
  CRow,
  CCol,
  CCard,
  CCardHeader,
  CCardBody,
  CSubheader,
  CBreadcrumbRouter,
  CLink,
  CWidgetIcon,
  CCardFooter,
  CFade,
  CCollapse,
  CProgress,
  CButton
} from "@coreui/react";
import { rgbToHex } from "@coreui/utils";
import { DocsLink } from "src/reusable";
import Board from "react-trello";
import CIcon from "@coreui/icons-react";

const Overview = () => {
  const [collapsed, setCollapsed] = React.useState(true);
  const [showCard, setShowCard] = React.useState(true);
  useEffect(() => {}, []);

  return (
    <CCard>
      <CSubheader className="px-3 justify-content-between">
        <div className="d-md-down-none mfe-2 c-subheader-nav">
          <CLink
            className="c-subheader-nav-link"
            aria-current="page"
            to="/dashboard"
          >
            <CIcon name="cil-graph" alt="Dashboard" />
            &nbsp;Tên dự án
          </CLink>
        </div>
        <div className="d-md-down-none mfe-2 c-subheader-nav">
          <CLink className="c-subheader-nav-link" href="#">
            <CIcon name="cil-speech" alt="Settings" />
          </CLink>
          <CLink
            className="c-subheader-nav-link"
            aria-current="page"
            to="/dashboard"
          >
            <CIcon name="cil-graph" alt="Dashboard" />
            &nbsp;Dashboard
          </CLink>
          <CLink className="c-subheader-nav-link" href="#">
            <CIcon name="cil-settings" alt="Settings" />
            &nbsp;Settings
          </CLink>
        </div>
      </CSubheader>
      <CRow style={{ marginTop: "20px" }}>
        <CCol xs="12" sm="12" md="12">
          <CCard>
            <CCardHeader>Nội dung dự án</CCardHeader>
            <CCardBody>
              Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam
              nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam
              erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci
              tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo
              consequat.
            </CCardBody>
          </CCard>
        </CCol>
        <CCol xs="12" sm="12" md="12">
          <CCard>
            <CCardHeader>Thông tin cơ bản</CCardHeader>
            <CCardBody>
            <CButton style={{width:"150px"}} block color="info">Thêm thành viên</CButton>
              <table className="table table-hover table-outline mb-0 d-none d-sm-table" style={{marginTop:"20px"}}>
                <thead className="thead-light">
                  <tr>
                    <th className="text-center">
                      <CIcon name="cil-people" />
                    </th>
                    <th>Tài khoản</th>
                    <th className="text-center">Quốc tịch</th>
                    <th>Phần trăm công việc</th>
                    <th className="text-center">Vai trò</th>
                    <th>Activity</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td className="text-center">
                      <div className="c-avatar">
                        <img
                          src={"avatars/1.jpg"}
                          className="c-avatar-img"
                          alt="admin@bootstrapmaster.com"
                        />
                        <span className="c-avatar-status bg-success"></span>
                      </div>
                    </td>
                    <td>
                      <div>Yiorgos Avraamu</div>
                      <div className="small text-muted">
                        <span>New</span> | Registered: Jan 1, 2015
                      </div>
                    </td>
                    <td className="text-center">
                      <CIcon height={25} name="cif-us" title="us" id="us" />
                    </td>
                    <td>
                      <div className="clearfix">
                        <div className="float-left">
                          <strong>50%</strong>
                        </div>
                        <div className="float-right">
                          <small className="text-muted">
                            Jun 11, 2015 - Jul 10, 2015
                          </small>
                        </div>
                      </div>
                      <CProgress
                        className="progress-xs"
                        color="success"
                        value="50"
                      />
                    </td>
                    <td className="text-center">
                      Member
                    </td>
                    <td>
                      <div className="small text-muted">Last login</div>
                      <strong>10 sec ago</strong>
                    </td>
                  </tr>
                  <tr>
                    <td className="text-center">
                      <div className="c-avatar">
                        <img
                          src={"avatars/2.jpg"}
                          className="c-avatar-img"
                          alt="admin@bootstrapmaster.com"
                        />
                        <span className="c-avatar-status bg-danger"></span>
                      </div>
                    </td>
                    <td>
                      <div>Avram Tarasios</div>
                      <div className="small text-muted">
                        <span>Recurring</span> | Registered: Jan 1, 2015
                      </div>
                    </td>
                    <td className="text-center">
                      <CIcon height={25} name="cif-br" title="br" id="br" />
                    </td>
                    <td>
                      <div className="clearfix">
                        <div className="float-left">
                          <strong>10%</strong>
                        </div>
                        <div className="float-right">
                          <small className="text-muted">
                            Jun 11, 2015 - Jul 10, 2015
                          </small>
                        </div>
                      </div>
                      <CProgress
                        className="progress-xs"
                        color="info"
                        value="10"
                      />
                    </td>
                    <td className="text-center">
                     Manager
                    </td>
                    <td>
                      <div className="small text-muted">Last login</div>
                      <strong>5 minutes ago</strong>
                    </td>
                  </tr>
                  <tr>
                    <td className="text-center">
                      <div className="c-avatar">
                        <img
                          src={"avatars/3.jpg"}
                          className="c-avatar-img"
                          alt="admin@bootstrapmaster.com"
                        />
                        <span className="c-avatar-status bg-warning"></span>
                      </div>
                    </td>
                    <td>
                      <div>Quintin Ed</div>
                      <div className="small text-muted">
                        <span>New</span> | Registered: Jan 1, 2015
                      </div>
                    </td>
                    <td className="text-center">
                      <CIcon height={25} name="cif-in" title="in" id="in" />
                    </td>
                    <td>
                      <div className="clearfix">
                        <div className="float-left">
                          <strong>74%</strong>
                        </div>
                        <div className="float-right">
                          <small className="text-muted">
                            Jun 11, 2015 - Jul 10, 2015
                          </small>
                        </div>
                      </div>
                      <CProgress
                        className="progress-xs"
                        color="warning"
                        value="74"
                      />
                    </td>
                    <td className="text-center">
                      Member
                    </td>
                    <td>
                      <div className="small text-muted">Last login</div>
                      <strong>1 hour ago</strong>
                    </td>
                  </tr>
                </tbody>
              </table>
            </CCardBody>
          </CCard>
        </CCol>
        <CCol xs="12" sm="6" md="4">
          <CFade in={showCard}>
            <CCard>
              <CCardHeader>
                Tài khoản client
                <div className="card-header-actions">
                  <CLink className="card-header-action">
                    <CIcon name="cil-settings" />
                  </CLink>
                  <CLink
                    className="card-header-action"
                    onClick={() => setCollapsed(!collapsed)}
                  >
                    <CIcon
                      name={
                        collapsed ? "cil-chevron-bottom" : "cil-chevron-top"
                      }
                    />
                  </CLink>
                  <CLink
                    className="card-header-action"
                    onClick={() => setShowCard(false)}
                  >
                    <CIcon name="cil-x-circle" />
                  </CLink>
                </div>
              </CCardHeader>
              <CCollapse show={collapsed}>
                <CCardBody>
                  tk:kakashi <br></br>
                  ml:uchiahj<br></br>
                  hoot:todohichi
                </CCardBody>
              </CCollapse>
            </CCard>
          </CFade>
        </CCol>
        <CCol xs="12" sm="6" md="4">
          <CFade in={showCard}>
            <CCard>
              <CCardHeader>
                Tài khoản FTP
                <div className="card-header-actions">
                  <CLink className="card-header-action">
                    <CIcon name="cil-settings" />
                  </CLink>
                  <CLink
                    className="card-header-action"
                    onClick={() => setCollapsed(!collapsed)}
                  >
                    <CIcon
                      name={
                        collapsed ? "cil-chevron-bottom" : "cil-chevron-top"
                      }
                    />
                  </CLink>
                  <CLink
                    className="card-header-action"
                    onClick={() => setShowCard(false)}
                  >
                    <CIcon name="cil-x-circle" />
                  </CLink>
                </div>
              </CCardHeader>
              <CCollapse show={collapsed}>
                <CCardBody>
                  tk :todoadon<br></br>
                  mk:1234556<br></br>
                  hoot :225.225.12.8
                </CCardBody>
              </CCollapse>
            </CCard>
          </CFade>
        </CCol>
        <CCol xs="12" sm="6" md="4">
          <CFade in={showCard}>
            <CCard>
              <CCardHeader>
                Tài khoảng server-Db
                <div className="card-header-actions">
                  <CLink className="card-header-action">
                    <CIcon name="cil-settings" />
                  </CLink>
                  <CLink
                    className="card-header-action"
                    onClick={() => setCollapsed(!collapsed)}
                  >
                    <CIcon
                      name={
                        collapsed ? "cil-chevron-bottom" : "cil-chevron-top"
                      }
                    />
                  </CLink>
                  <CLink
                    className="card-header-action"
                    onClick={() => setShowCard(false)}
                  >
                    <CIcon name="cil-x-circle" />
                  </CLink>
                </div>
              </CCardHeader>
              <CCollapse show={collapsed}>
                <CCardBody>
                  hoot:mikami.tara.com<br></br>
                  user:nomikata<br></br>
                  pass:hichito
                </CCardBody>
              </CCollapse>
            </CCard>
          </CFade>
        </CCol>
      </CRow>
    </CCard>
  );
};
export default Overview;
