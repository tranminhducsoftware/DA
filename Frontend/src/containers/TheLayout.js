import React from 'react'
import { useSelector, useDispatch } from 'react-redux'
import {
  TheContent,
  TheSidebar,
  TheFooter,
  TheHeader,
} from './index'


const TheLayout = () => {
  return (
    <div className="c-app c-default-layout">
      <TheSidebar />
      <div className="c-wrapper">
        <div className="c-body">
          <TheContent />
        </div>
      </div>
    </div>
  )
}

export default TheLayout
